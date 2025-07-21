using Microsoft.AspNetCore.Mvc;
using ReporterDay.BusinessLayer.Abstract;
using ReporterDay.EntityLayer.Entities;

namespace ReporterDay.PresentationLayer.Controllers
{
    public class SliderController : Controller
    {
        private readonly ISliderService _sliderservice;

        public SliderController(ISliderService sliderservice)
        {
            _sliderservice = sliderservice;
        }

        public IActionResult SliderList()
        {
            var values = _sliderservice.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSlider(Slider slider)
        {
            _sliderservice.TInsert(slider);
            return RedirectToAction("SliderList");
        }
        public IActionResult DeleteSlider(int id)
        {
            _sliderservice.TDelete(id);
            return RedirectToAction("SliderList");
        }
        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            var value = _sliderservice.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSlider(Slider slider)
        {
            _sliderservice.TUpdate(slider);
            return RedirectToAction("SliderList");
        }
    }
}
