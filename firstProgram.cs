/*source : https://docs.microsoft.com/fr-fr/dotnet/csharp/tour-of-csharp/tutorials/hello-world?tutorial-step=1*/


Console.WriteLine("Hello World!");

/*Félicitations ! Vous avez exécuté votre premier programme C#. Il s’agit d’un programme simple qui affiche le message « Hello World! ». 
Il a utilisé la méthode Console.WriteLine pour afficher ce message. Console est un type qui représente la fenêtre de console. WriteLine est une 
méthode du type Console qui affiche une ligne de texte sur cette console de texte.

Poursuivons notre exploration. Le reste de cette leçon explore l’utilisation du type string, qui représente du texte en C#. À l’instar du type Console, 
le type string propose différentes méthodes. La méthode string fonctionne avec du texte.*/

string aFriend = "Bill";
Console.WriteLine(aFriend);

/*La première ligne déclare une variable, aFriend , et lui assigne une valeur, « Bill ». La deuxième ligne affiche le nom.

Vous pouvez assigner des valeurs différentes à toute variable que vous déclarez. Vous pouvez remplacer le nom par celui d’un de vos amis. 
Ajoutez ces deux lignes dans la fenêtre interactive à la suite du code que vous avez déjà ajouté. Veillez à conserver la déclaration de la aFriend variable et 
son affectation initiale.*/

aFriend = "Maira";
Console.WriteLine(aFriend);

/*Notez que la même ligne de code affiche deux messages différents, selon la valeur stockée dans la variable aFriend.

Vous avez peut-être également remarqué que le mot « Hello » manque dans les deux derniers messages. Nous allons résoudre ce problème maintenant. 
Modifiez les lignes qui affichent le message comme suit :*/

