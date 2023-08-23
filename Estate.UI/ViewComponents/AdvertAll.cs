﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;


namespace Estate.UI.ViewComponents
{
    public class AdvertAll : ViewComponent
    {
        ImagesService im;
        AdvertService advert;
        public AdvertAll(ImagesService im, AdvertService advert)
        {
            this.im = im;
            this.advert = advert;
        }
        public IViewComponentResult Invoke(int page = 1)
        {
            var list = advert.List(x => x.Status == true);
            var images = im.List(x => x.Status == true);
            ViewBag.imgs = images;
            return View(list);
        }
    }
}
