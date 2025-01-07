var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapClassificationRoutes();

app.MapGet("/", () =>
    """ 
    Welcome to Nash API
    NOTE : Enable Pretty print it is on top of the window 
    
    API Routes  :
            /classification
                /classification/Domain-Archaea
                /classification/Domain-Bacteria
                /classification/Domain-Eukarya
                /classification/Kingdom-Protista
                /classification/Kingdom-Fungi
                /classification/Kingdom-Plant
                /classification/Features-of-non-flowering-seedless-plants
                /classification/Features-of-flowering-plants
                /classification/Features-of-monocots
                /classification/Features-of-dicots
                /classification/Kingdom-Animalia
                /classification/Kingdom-Animalia/Invertebrates
                /classification/Kingdom-Animalia/Vertebrates
                /classification/Kingdom-Animalia/Invertebrates/Features-of-porifera
                /classification/Kingdom-Animalia/Invertebrates/Features of coelenterata
                /classification/Kingdom-Animalia/Invertebrates/Features of platyhelminthes
                /classification/Kingdom-Animalia/Invertebrates/Features-of-nematoda
                /classification/Kingdom-Animalia/Invertebrates/Features-of-arthropoda
                /classification/Kingdom-Animalia/Invertebrates/Features-of-mollusca
                /classification/Kingdom-Animalia/Invertebrates/Features of nemato
                /classification/Kingdom-Animalia/Invertebrates/Features-of-echinodermata
                /classification/Kingdom-Animalia/Vertebrates/Features-of-fish
                /classification/Kingdom-Animalia/Vertebrates/Features-of-amphibians
                /classification/Kingdom-Animalia/Vertebrates/Features-of-reptiles
                /classification/Kingdom-Animalia/Vertebrates/Features-of-birds
                /classification/Kingdom-Animalia/Vertebrates/Features-of-mammals
                /classification/Nomenclature
    """
);
app.Run();