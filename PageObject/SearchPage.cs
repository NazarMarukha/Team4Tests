using OpenQA.Selenium;
/*бля чувак це пісец хз чи ти це читаєш, але якщо читаєш то знай це пісец я на то щоб натиснути кнопку в модальному вікні
 потратив добу, це бля я в афізі, я цілу добу пробував сам шось замутити, я перерив дофіга сторінок в неті, даже 
 стековерфлоу не поміг, там така фігня була шо псдц, я індусів якихось дивився (хоча в 2х швидкості це навіть забавно було)
 ніфіга не помагало і от я ночку не спав зранку вже втративши всяку надію просто пишу звичайні виклики без вейтерів,
 без нічого і знаєш шо? --- воно запахало, тут просто мій мозок вийшов у вікно*/
namespace Team4Tests.PageObject
{
    public class SearchPage : ObjectBase
    {
        public SearchPage(IWebDriver driver):base(driver){}
        public SearchPage ClickOn()
        {
            Driver.FindElement(By.CssSelector("button[class='btn btn-primary add-to-cart']")).Click();
            return this;
        }
        
        public Cart AddToCart()
        {
            Driver.FindElement(By.CssSelector("a[class='btn btn-primary']")).Click();
            return new Cart(Driver);
        }
    }
}