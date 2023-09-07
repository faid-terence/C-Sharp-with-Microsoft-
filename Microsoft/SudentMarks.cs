// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sofiaMarks = sophia1+sophia2+sophia3+sophia4+sophia5;
double sofiaAverage = (double)sofiaMarks/(double)currentAssignments;

int nicolasMarks = nicolas1+nicolas2+nicolas3+nicolas4+nicolas5;
double nicolasAverage = (double)nicolasMarks/(double) currentAssignments;

int zahirahMarks = zahirah1+zahirah2+zahirah3+zahirah4+zahirah5;
double zahirahAverage = (double)zahirahMarks/ (double) currentAssignments;

int jeongMarks = jeong1+jeong2+jeong3+jeong4+jeong5;
double joeongAverage = (double)jeongMarks/ (double)currentAssignments;



Console.Write("Student      \t");
Console.Write("Grade");
Console.WriteLine("\n");
Console.Write("Sophia        \t");
Console.Write(sofiaAverage);
Console.Write(" \tA");
Console.WriteLine("\n");
Console.Write("Nicolas      \t");
Console.Write(nicolasAverage);
Console.Write(" \tB");
Console.WriteLine("\n");
Console.Write("Zahirah       \t");
Console.Write(zahirahAverage);
Console.Write(" \tB");
Console.WriteLine("\n");
Console.Write("Joeng        \t");
Console.Write(joeongAverage);
Console.Write(" \tA");
