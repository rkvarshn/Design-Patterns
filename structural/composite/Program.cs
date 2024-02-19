using composite;

FileComponent myBio = new("Rishabh Bio");

FolderComponent games = new("Games");
games.Add(new FileComponent("Mario"));
games.Add(new FileComponent("Pacman"));
FolderComponent pop = new("Prince of Persia");
pop.Add(new FileComponent("Sands of Time"));
pop.Add(new FileComponent("Warrior Within"));
pop.Add(new FileComponent("The two Thrones"));
games.Add(pop);

FolderComponent music = new("Music");
music.Add(new FileComponent("Hall of fame"));
music.Add(new FileComponent("Dream On"));
FolderComponent rihanna = new("Rihanna");
rihanna.Add(new FileComponent("Rude Boy"));
rihanna.Add(new FileComponent("Diamonds"));
rihanna.Add(new FileComponent("We found love"));
music.Add(rihanna);
FolderComponent sia = new("Sia");
sia.Add(new FileComponent("Chandelier"));
FolderComponent siaThisIsActing = new("This is Acting");
siaThisIsActing.Add(new FileComponent("Unstoppable"));
siaThisIsActing.Add(new FileComponent("Cheap Thrills"));
siaThisIsActing.Add(new FileComponent("Bird Set Free"));
sia.Add(siaThisIsActing);
sia.Add(new FileComponent("Elastic Heart"));
sia.Add(new FileComponent("The Greatest"));
music.Add(sia);

FolderComponent myComputer = new("This PC");
myComputer.Add(games);
myComputer.Add(myBio);
myComputer.Add(music);

// calling print on root of the tree will print entire heirarchy
myComputer.Print();