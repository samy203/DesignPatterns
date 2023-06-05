using Prototype;

ConcreteMixer mixer = new ConcreteMixer();
// Initialize with standard colors
mixer["soft"] = new ConcreteMix(70, 25, 5);
mixer["mid"] = new ConcreteMix(65, 30, 5);
mixer["hard"] = new ConcreteMix(55, 35, 10);

// User clones selected colors
ConcreteMix softMix = mixer["soft"].Clone() as ConcreteMix;
ConcreteMix midMix = mixer["mid"].Clone() as ConcreteMix;
ConcreteMix hardMix = mixer["hard"].Clone() as ConcreteMix;
// Wait for user
Console.ReadKey();