using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace Estate.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdvertController : Controller
    {
        AdvertService advertService;
        CityService cityService;
        DistrictService districtService;
        NeighbourhoodService neighbourhoodService;
        SituationService situationService;
        TypeService typeService;
        ImagesService imageService;

        IWebHostEnvironment hostEnvironment;
        public AdvertController(AdvertService advertService, CityService cityService,DistrictService districtService, NeighbourhoodService neighbourhoodService, SituationService situationService,ImagesService imageService, TypeService typeService,IWebHostEnvironment hostEnvironment)
        {
            this.advertService = advertService;
            this.cityService = cityService;
            this.districtService = districtService;
            this.neighbourhoodService = neighbourhoodService;
            this.situationService = situationService;
            this.typeService = typeService;
            this.imageService = imageService;
            this.hostEnvironment = hostEnvironment;
            
        }
        public IActionResult Index()
        {
            string id = HttpContext.Session.GetString("Id");
            var list = advertService.List(x => x.Status == true && x.UserAdminId == id);
            return View(list);
        }

        public IActionResult AdvertAll()
        {
            string id = HttpContext.Session.GetString("Id");

            var list = advertService.List(x => x.Status == true && x.UserAdminId != id);
            return View(list);
        }

        public IActionResult ImageList(int id)
        {
            var list = imageService.List(x => x.Status == true && x.AdvertId == id);

            return View(list);
        }
        public IActionResult Create() 
        {
            ViewBag.userid = HttpContext.Session.GetString("Id");
            DropDown();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Advert data)
        {
            //await mediator.Send(createAdvertCommand);
            //return RedirectToAction("Index");

            AdvertValidation validationRules = new AdvertValidation();
            ValidationResult result = validationRules.Validate(data);

            if (result.IsValid)
            {
                if (data.Image != null)
                {
                    var dosyayolu = Path.Combine(hostEnvironment.WebRootPath, "img");

                    foreach (var item in data.Image)
                    {
                        var tamDosyaAdi = Path.Combine(dosyayolu, item.FileName);

                        using (var dosyaAkisi = new FileStream(tamDosyaAdi, FileMode.Create))
                        {
                            item.CopyTo(dosyaAkisi);
                        }

                        data.Images.Add(new Images { ImageName = item.FileName, Status = true });
                    }

                    advertService.Add(data);

                    TempData["Success"] = "İlan Ekleme İşlemi Başarıyla Gerçekleşti";
                    return RedirectToAction("Index");
                } 
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            DropDown();
            return View();
        }


        public IActionResult Update(int id)
        {
            ViewBag.userid = HttpContext.Session.GetString("Id");
            DropDown();
            var advert = advertService.GetById(id);
            return View(advert);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Advert data)
        {
            AdvertValidation validationRules = new AdvertValidation();
            ValidationResult result = validationRules.Validate(data);

            if (result.IsValid)
            {


                advertService.Update(data);

                TempData["Update"] = "İlan Güncelleme İşlemi Başarıyla Gerçekleşti";
                return RedirectToAction("Index");
            }

            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            DropDown();
            return View(data);
        }
        public IActionResult Delete(int id)
        {
            var sessionuser = HttpContext.Session.GetString("Id");

            var delete = advertService.GetById(id);

            if (sessionuser.ToString() == delete.UserAdminId)
            {
                advertService.Delete(delete);
                return RedirectToAction("Index");
            }
            return View();
        }

        public List<City> CityGet()
        {
            List<City> cities=cityService.List(x => x.Status == true);
            return cities;
        }

        public List<Situation> SituationGet()
        {
            List<Situation> situations = situationService.List(x => x.Status == true);
            return situations;
        }

        public IActionResult DistrictGet(int CityId)
        {
            List<District> districtlist = districtService.List(x => x.Status == true && x.CityId==CityId);
            ViewBag.district = new SelectList(districtlist, "DistrictId", "DistrictName");
            return PartialView("DistrictPartial");
        }

        public PartialViewResult DistrictPartial()
        {
            return PartialView();
        }

        public PartialViewResult TypePartial()
        {
            return PartialView();
        }

        public PartialViewResult NeighbourhoodPartial()
        {
            return PartialView();
        }
        public IActionResult TypeGet(int SituationId)
        {
            List<EntityLayer.Entities.Type> typelist = typeService.List(x => x.Status == true && x.SituationId == SituationId);
            ViewBag.type = new SelectList(typelist, "TypeId", "TypeName");
            return PartialView("TypePartial");
        }

        public IActionResult NeighbourhoodGet(int DistrictId)
        {
            List<Neighbourhood> neighlist = neighbourhoodService.List(x => x.Status == true && x.DistrictId == DistrictId);

            ViewBag.neigh = new SelectList(neighlist, "NeighbourhoodId", "NeighbourhoodName");
            return PartialView("NeighbourhoodPartial");
        }
        public void DropDown()
        {
            ViewBag.citylist = new SelectList(CityGet(), "CityId", "CityName");
            ViewBag.situations = new SelectList(SituationGet(), "SituationId", "SituationName");

            List<SelectListItem> value1 = (from i in districtService.List(X => X.Status == true)
                                           select new SelectListItem
                                           {
                                               Text = i.DistrictName,
                                               Value = i.DistrictId.ToString()
                                           }).ToList();
            ViewBag.district = value1;

            List<SelectListItem> value2 = (from i in neighbourhoodService.List(x => x.Status == true)
                                           select new SelectListItem
                                           {
                                               Text = i.NeighbourhoodName,
                                               Value = i.NeighbourhoodId.ToString()
                                           }).ToList();
            ViewBag.neighbourhood = value2;
            List<SelectListItem> value3 = (from i in typeService.List(x => x.Status == true)
                                           select new SelectListItem
                                           {
                                               Text = i.TypeName,
                                               Value = i.TypeId.ToString()
                                           }).ToList();
            ViewBag.type = value3;

            List<SelectListItem> value4 = (from i in situationService.List(x => x.Status == true)
                                           select new SelectListItem
                                           {
                                               Text = i.SituationName,
                                               Value = i.SituationId.ToString()
                                           }).ToList();
            ViewBag.situation = value4;
        }
    }
}
