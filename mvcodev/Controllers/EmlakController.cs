using Microsoft.AspNetCore.Mvc;
public class emlakController:Controller
{
    public IActionResult Satilik(){
        var emlak = new EmlakModel
        {
            yer = "Seyrek",
            mk = 150,
            bahce = "evet",
            imgyol = "~/emlak.jpg",
            yer2 = "Menemen",
            mk2 = 100,
            bahce2 = "Hayir",
            imgyol2 = "ev4.jpg",
        };
        ViewBag.Emlak=emlak;
        return View();
    }
    public IActionResult Kiralik(){
        var emlak = new EmlakModel
        {
            yer = "Bostanli",
            mk = 130,
            bahce = "evet",
            imgyol = "~/emlak.jpg",
            yer2 = "Örnekköy",
            mk2 = 90,
            bahce2 = "Hayir",
            imgyol2 = "ev4.jpg",
        };
        ViewBag.Emlak=emlak;
        return View();
    }
}
