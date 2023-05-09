using Composite;

var scorias = new Person("Scorias");
var worldDj = new Person("WorldDj");
var salem = new Person("Salem");
var mohy = new Person("Mohy");

var stackHolders = new List<StackHolder>() {
    scorias,
    worldDj,
    new Company("ITI",
        new List<Person> {
            salem,
            mohy
        })
};

var profitShare = 5000;
foreach (var stackHolder in stackHolders)
{
    stackHolder.Networth += profitShare;
    stackHolder.GetNetworth();
}