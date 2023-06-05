using Memento;

Originator org = new Originator();
org.State = "You are Positive.";

Caretaker c = new Caretaker();
c.Memento = org.CreateMemento();

org.State = "You are Negative.";
org.SetMemento(c.Memento);
