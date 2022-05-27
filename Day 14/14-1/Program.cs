Message message = MessageOne;
message += MessageTwo;
message += MessageThree;
PrintMessage(message);



void MessageOne() => Console.WriteLine("Hello world!");
void MessageTwo() => Console.WriteLine("Bye!");
void MessageThree() => Console.WriteLine("Good morning!");

void PrintMessage(Message someMessage) => someMessage();

delegate void Message();