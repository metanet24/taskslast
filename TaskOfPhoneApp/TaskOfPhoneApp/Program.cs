using TaskOfPhoneApp.Controllers;

ContactController contactController=new ContactController();

Console.WriteLine("Choose op 1-Create , 2-GetAll");
Choice: string op=Console.ReadLine();

if (op == "1")
{
    contactController.Add();
    goto Choice;

}else if (op == "2")
{
    contactController.GetAll();
}