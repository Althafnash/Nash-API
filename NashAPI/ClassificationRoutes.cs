// ClassificationRoutes.cs
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

public static class ClassificationRoutes
{
    public static void MapClassificationRoutes(this WebApplication app)
    {
        app.MapGet("/classification", () =>
            Results.Json(new
            {
                Topic = "classification of organisms ",
                Notes = new
                {
                    Classification = "Grouping animals into different levels based on their common characteristics is known as classification",
                    Significance_of_classification = "Grouping animals into different levels based on their common characteristics is known as classification",
                    Importance = new
                    {
                        Importance_1 = "Easy to study organisms",
                        Importance_2 = "Ability to identify specific distinguishing characteristics of organisms",
                        Importance_3 = "Ability to gain new insights about the whole biosphere",
                        Importance_4 = "Ability to reveal different relationships among organisms",
                        Importance_5 = "Identification of organisms with economic use for humans"
                    },
                    Fact1 = "Aristotle introduced the first scientific classification of organisms.",
                    Fact2 = "Carolus Linnaeus in the 18th century introduced a successful classification method.",
                }
            })
        );

        app.MapGet("/classification/Domain-Archaea", () =>
            Results.Json(new
            {
                Topic = "Organisms in Domain Archaea",
                Notes = new
                {
                    Fact1 = "Prokaryotic – without an organized nucleus",
                    Fact2 = "Have the ability to live in extreme environments",
                    Fact3 = "Cannot be destroyed by antibiotics",
                }
            })
        );

        app.MapGet("/classification/Domain-Bacteria", () =>
            Results.Json(new
            {
                Topic = "Organisms in Domain Bacteria",
                Notes = new
                {
                    Fact1 = "Prokaryotic",
                    Fact2 = "Pathogenic",
                    Fact3 = "Sensitive to antibiotics",
                    Fact4 = "Can be found everywhere in the environment",
                    Fact5 = "Are the most abundant group of organisms",
                    Fact6 = "Bacteria and cyanobacteria belong to this group"
                }
            })
        );

        app.MapGet("/classification/Domain-Eukarya", () =>
            Results.Json(new
            {
                Topic = "Organisms in Domain Eukarya",
                Notes = new
                {
                    Fact1 = "Eukaryotic cellular organisms",
                    Fact2 = "Not sensitive to antibiotics",
                    Fact3 = "Live in various environments"
                }
            })
        );

        app.MapGet("/classification/Kingdom-Protista",()=>
            Results.Json(new 
                {
                    Topic = "Kingdom Protista",
                    Notes = new {
                        Fact1 = "Organisms belonging to Kingdom Protista possess eukaryotic cellular organization.",
                        Fact2  = "They are unicellular or multicellular organisms without specific tissues.",
                        Fact3 = "Some are heterotrophic.",
                        Fact4 = "Algae and protozoa belong to this group.",
                        Fact5 = "Some harmful and useful effects of Protista",
                        effects = new {
                            Fact1 = "Algae act as the primary food source in the aquatic environment",
                            Fact2 = "Algae help in the production of lichens",
                            Fact3 = "Alginic acid extracted from algae is needed for ice cream production",
                            Fact4 = "Some protozoans cause harmful effects on humans"
                        }
                    }
                }
            )
        );

        app.MapGet("/classification/Kingdom-Fungi",()=>
            Results.Json(new 
                {
                    Topic = "Kingdom Fungi",
                    Fact1 = "Kingdom Fungi is characterized by a chitinous cell wall and eukaryotic cellular organization.",
                    Bactria = new {
                        Topic = "Features of Bacteria",
                        Structure = new {
                            Fact1 = "Microscopic",
                            Fact2 = "Unicellular",
                            Fact3 = "Prokaryotic"
                        },
                        Shape = new {
                            Fact1 = "Spherical",
                            Fact2 = "Rod-shaped",
                            Fact3 = "Spiral-shaped",
                            Fact4 = "Comma-shaped"
                        },
                        Fact2 = "Nutrition: Mostly heterotrophic, but cyanobacteria are autotrophic",
                        Fact3 = "Reproduction: Mostly asexual",
                        Fact4 = "Distribution: Almost everywhere"
                    },
                    Protista = new {
                        Topic = "Features of Protista",
                        Structure = new {
                            Fact1 = "Most are microscopic",
                            Fact2 = "Some red algae have large bodies",
                            Fact4 = "Eukaryotic"
                        },
                        Shape = new {
                            Fact1 = "Leaf-like",
                            Fact2 = "Horse-shaped",
                            Fact3 = "Shoe-shaped"
                        },
                        Distribution = new {
                            Fact1 = "Marine water",
                            Fact2 = "Freshwater",
                            Fact3 = "Damp soil",
                            Fact4 = "Inside other organisms"
                        },
                        Fact1 = "Nutrition: Algae are autotrophic, while other organisms are heterotrophic",
                        Fact2 = "Reproduction: Asexual reproduction"
                    },
                    Fungi = new {
                        Topic = "Features of Fungi",
                        Structure = new {
                            Fact1 = "Microscopic",
                            Fact2 = "Mushroom reproductive organs can be seen",
                            Fact3 = "Eukaryotic"
                        },
                        Shape = new {
                            Fact1 = "Leaf-like",
                            Fact2 = "Horse-shaped",
                            Fact3 = "Shoe-shaped",
                        },

                        Fact1 = "Nutrition: All are heterotrophic",
                        Fact2 = "Reproduction: Mostly asexual",
                        Fact3 = "Distribution: Organic matter and Living bodies"
                    }
                }
            )
        );

        app.MapGet("/classification/Kingdom-Plant",()=>
            Results.Json(new
                {
                    Topic = "Kingdom Plant",
                    Notes = new {
                        Fact1 = "Plants can be divided into two categories:",
                        Plants_categories = new {
                            Fact1 = "Flowering plants",
                            Fact2 = "Non-flowering plants"
                        },
                        Fact2 = "Flowering plants can be further divided into",
                        FloweringPlants_categories = new {
                            Fact1 = "Dicots",
                            Fact2 = "Monocots"
                        },
                        Fact3 = "Non-flowering plants can be divided into:",
                        NonFloweringPlants_categories = new {
                            Fact1 = "Seeded plants",
                            Fact2 = "Seedless plants"
                        },

                    }
                }
            )
        );

        app.MapGet("/classification/Features-of-non-flowering-seedless-plants",()=> 
            Results.Json(new 
                {
                    Topic = "Features of non-flowering seedless plants",
                    Notes = new {
                        Structure = new {
                            Fcat1 = "Small to large-sized plants",
                            Fact2 = "Some plants lack tissue differentiation",
                            Fact3 = "No stem, leaves, and root",
                            Fact4 = "These plants are known as thallus",
                            Fact5 = "Some plants possess vascular tissue"
                        },
                        Reproduction = new {
                            Fact1 = "Asexual reproduction",
                            Fact2 = "Sexual reproduction",
                            Fact3 = "Fragmentation of vegetative parts"
                        },
                        Fact1 = "Shape: Thalloid body or fern-like shape",
                        Fcat2 = "Nutrition: All are autotrophic and photosynthetic",
                        Fact3 = "Distribution: Terrestrial environment with low sunlight"
                    }
                }
            )
        );

        app.MapGet("/classification/Features-of-flowering-plants",()=>
            Results.Json(new
                {
                    Topic = "Features of flowering plants",
                    Notes = new {
                        Structure = new {
                            Fact1 = "Tissue differentiation",
                            Fact2 = "Vascular tissue",
                            Fact3 = "Root, stem, and leaves are present"
                        },
                        Shape = new {
                            Fact1 = "Large in size",
                            Fact2 = "Most are trees",
                            Fact3 = "Woody stems",
                            Fact4 = "Some are shrubs"
                        },
                        Reproduction = new {
                            Fact1 = "Sexual reproduction by seed",
                            Fact2 = "Asexual reproduction by spores"
                        },
                        Fact1 = "Nutrition: All are autotrophic and photosynthetic",
                        Fact2 = "Distribution: Terrestrial environment"
                    }
                }
            )
        );

        app.MapGet("/classification/Features-of-monocots",()=>
            Results.Json(new 
                {
                    Topic = "Features of monocots",
                    Notes = new {
                        Fact1 = "Single seed coat",
                        Fact2 = "Unbranched stems",
                        Fcat3 = "Fibrous root system",
                        Fact4 = "Parallel venation",
                        Fact5 = "Trimerous flowers",
                        Fact6 = "No secondary growth",
                        Fact7 = "Even stem diameter"
                    }
                }
            )
        );

        app.MapGet("/classification/Features-of-dicots",()=>
            Results.Json(new 
                {
                    Topic = "Features of dicots",
                    Notes = new {
                        Fact1 = "Two seed coats",
                        Fact2 = "Branched stems",
                        Fact3 = "Taproot system",
                        Fact5 = "Reticulate venation",
                        Fact6 = "Tetramerous flowers",
                        Fact7 = "Secondary growth",
                        Fact8 = "Broad base",
                        Fact9 = "Thin tip"
                    }
                }
            )
        );

        app.MapGet("/classification/Kingdom-Animalia",()=>
            Results.Json(new 
                {
                    Topic = "Kingdom Animalia",
                    Notes = new {
                        Fact1 = "Kingdom Animalia can be divided into two",
                        Divisions = new {
                            Fact1 = "Invertebrates",
                            Fact2 = "Vertebrates" 
                        }
                    }
                }
            )   
        );
        
        app.MapGet("/classification/Kingdom-Animalia/Invertebrates",()=>
            Results.Json(new 
                {
                    Topic = "Invertebrates ",
                    Notes = new {
                        Fact1 = "Invertebrates can be divided into eight",
                        Divisions = new {
                            Fact1 = "poriferans ",
                            Fact2 = "Coelenterata",
                            Fact3 = "Platyhelminthes",
                            Fact4 = "Nematoda",
                            Fact5 = "Annelida",
                            Fact6 = "Arthropoda",
                            Fact7 = "Mollusca",
                            Fact8 = "Echinodermata" 
                        }
                    }
                }
            )   
        );

        app.MapGet("/classification/Kingdom-Animalia/Vertebrates ",()=>
            Results.Json(new 
                {
                    Topic = "Vertebrates  ",
                    Notes = new {
                        Fact1 = "Vertebrates  can be divided into eight",
                        Divisions = new {
                            Fact1 = "Fish ",
                            Fact2 = "Amphibians",
                            Fact3 = "Reptiles",
                            Fact4 = "Birds",
                            Fact5 = "Mammals",
                        }
                    }
                }
            )   
        );


        app.MapGet("/classification/Kingdom-Animalia/Invertebrates/Features-of-porifera",()=>
            Results.Json(new 
                {
                    Topic = "Features of porifera ",
                    Notes = new {
                        Fact1 = "Features of porifera",
                        Divisions = new {
                            Fact1 = "Shape: Variable shapes ",
                            Fact2 = "Nutrition : Filter feeders",
                            Fact3 = "Distribution : Marine water",
                            Reproduction = new {
                                Fact1 = "Asexual reproduction",
                                Fact2 = "Sexual reproduction"
                            },
                            Shape = new {
                                Fact1 = "Microscopic",
                                Fact2 = "Filter feeders",
                                Fact3 = "No specialized tissues",
                                Fact4 = "No symmetry"
                            } 
                        }
                    }
                }
            )   
        );

        app.MapGet("/classification/Kingdom-Animalia/Invertebrates/Features of coelenterata",()=>
            Results.Json(new 
                {
                    Topic = "Features of coelenterata ",
                    Notes = new {
                        Fact1 = "Features of coelenterata ",
                        Divisions = new {
                            Fact1 = "Nutrition : Holozoic nutrition ",
                            Fact2 = "Shape: Various shapes",
                            Structure = new {
                                Fact1 = "Simple animals",
                                Fact2 = "Two-layered body plan",
                                Fact3 = "Presence of a coelenteron",
                                Fact4 = "Radial symmetry"
                            },
                            Reproduction = new {
                                Fact1 = "Asexual reproduction",
                                Fact2 = "Sexual reproduction"
                            },
                            Distribution = new {
                                Fact1 = "Marine water",
                                Fact2 = "Freshwater"
                            }
                        }
                    }
                }
            )   
        );

        app.MapGet("/classification/Kingdom-Animalia/Invertebrates/Features of platyhelminthes",()=>
            Results.Json(new 
                {
                    Topic = "Features of platyhelminthes ",
                    Notes = new {
                        Fact1 = "Features of platyhelminthes",
                        Divisions = new {
                            Structure = new {
                                Fcat1 = "Flatworms",
                                Fcat2 = "Bilateral symmetry",
                                Fcat3 = "Three-layered body plan",
                                Fact4 = "No specialized circulatory system"
                            },
                            Fact2 = "Shape: Flat and elongated",
                            Fact3 = "Nutrition: Holozoic nutrition",
                            Reproduction = new {
                                Fact1 = "Asexual reproduction",
                                Fact2 = "Sexual reproduction"
                            },
                            Distribution = new {
                                Fact1 = "Marine water",
                                Fcat2 = "Freshwater" 
                            },
                        }
                    }
                }
            )   
        );

        app.MapGet("/classification/Kingdom-Animalia/Invertebrates/Features-of-nematoda",()=>
            Results.Json(new 
                {
                    Topic = "Features of nematoda ",
                    Notes = new {
                        Fact1 = "Features of nematoda",
                        Divisions = new {
                            Structure = new{
                                Fact1 = "Roundworms",
                                Fact2 = "Bilateral symmetry",
                                Fact3 = "Three-layered body plan",
                                Fact4 = "Presence of a pseudocoelom"
                            },
                            Fact2 = "Shape: Cylindrical shape",
                            Fact3 = "Nutrition: Holozoic nutrition",
                            Reproduction = new {
                                Fcat1 = "Asexual reproduction",
                                Fcat2 = "Sexual reproduction"
                            },
                            Distribution = new {
                                Fact1 = "Soil",
                                Fact2 = "Parasites in animals"
                            },
                        }
                    }
                }
            )   
        );

        app.MapGet("/classification/Kingdom-Animalia/Invertebrates/Features-of-arthropoda",()=>
            Results.Json(new 
                {
                    Topic = "Features of arthropoda",
                    Notes = new {
                        Fact1 = "Features of arthropoda",
                        Divisions = new {
                            Structure = new {
                                Fact1 = "Jointed-legged animals",
                                Fcat2 = "Exoskeleton made of chitin",
                                Fact3 = "Bilateral symmetry"
                            },
                            Shape = new {
                                Fact1 = "Segmented body",
                            },
                            Reproduction = new {
                                Fact1 = "Asexual reproduction",
                                Fact2 = "Sexual reproduction"
                            },
                            Distribution =new {
                                Fact1 = "All types of environments",
                            },
                            Fact1 = "Nutrition: Holozoic nutrition"
                        }
                    }
                }
            )   
        );

        app.MapGet("/classification/Kingdom-Animalia/Invertebrates/Features-of-mollusca",()=>
            Results.Json(new 
                {
                    Topic = "Features of nematoda ",
                    Notes = new {
                        Fact1 = "Features of nematoda",
                        Divisions = new {
                            Structure = new{
                                Fact1 = "Roundworms",
                                Fact2 = "Bilateral symmetry",
                                Fact3 = "Three-layered body plan",
                                Fact4 = "Presence of a pseudocoelom"
                            },
                            Fact2 = "Shape: Cylindrical shape",
                            Fact3 = "Nutrition: Holozoic nutrition",
                            Reproduction = new {
                                Fcat1 = "Asexual reproduction",
                                Fcat2 = "Sexual reproduction"
                            },
                            Distribution = new {
                                Fact1 = "Soil",
                                Fact2 = "Parasites in animals"
                            },
                        }
                    }
                }
            )   
        );

        app.MapGet("/classification/Kingdom-Animalia/Invertebrates/Features of nematoda",()=>
            Results.Json(new 
                {
                    Topic = "Features of mollusca",
                    Notes = new {
                        Fact1 = "Features of mollusca",
                        Divisions = new {
                            Structure = new{
                                Fact1 = "Soft-bodied animals",
                                Fact2 = "Presence of a mantle",
                                Fact3 = "Bilateral symmetry",
                            },
                            Fact2 = "Shape: Varied shapes",
                            Fact3 = "Nutrition: Holozoic nutrition",
                            Reproduction = new {
                                Fcat1 = "Asexual reproduction",
                                Fcat2 = "Sexual reproduction"
                            },
                            Distribution = new {
                                Fact1 = "Marine water",
                                Fact2 = "Freshwater"
                            },
                        }
                    }
                }
            )   
        );

        app.MapGet("/classification/Kingdom-Animalia/Invertebrates/Features-of-echinodermata",()=>
            Results.Json(new 
                {
                    Topic = "Features of echinodermata ",
                    Notes = new {
                        Fact1 = "Features of echinodermata",
                        Divisions = new {
                            Structure = new{
                                Fact1 = "Spiny-skinned animals",
                                Fact2 = "Presence of a water vascular system",
                                Fact3 = "Radial symmetry",
                            },
                            Fact2 = "Star-shaped",
                            Fact3 = "Nutrition: Holozoic nutrition",
                            Reproduction = new {
                                Fcat1 = "Asexual reproduction",
                                Fcat2 = "Sexual reproduction"
                            },
                            Distribution = new {
                                Fact1 = "Marine water",
                            },
                        }
                    }
                }
            )   
        );

        app.MapGet("/classification/Kingdom-Animalia/Vertebrates/Features-of-fish",()=>
            Results.Json(new 
                {
                    Topic = "Features of fish ",
                    Notes = new {
                        Fact1 = "Features of fish",
                        Divisions = new {
                            Structure = new{
                                Fact1 = "Presence of gills",
                                Fact2 = "Presence of scales",
                                Fact3 = "Two-chambered heart",
                            },
                            Fact2 = "Shape: Streamlined body",
                            Fact3 = "Nutrition: Holozoic nutrition",
                            Reproduction = new {
                                Fcat1 = "Asexual reproduction",
                                Fcat2 = "Sexual reproduction"
                            },
                            Distribution = new {
                                Fact1 = "Freshwater",
                                Fact2 = "Marine water"
                            },
                        }
                    }
                }
            )   
        );

        app.MapGet("/classification/Kingdom-Animalia/Vertebrates/Features-of-amphibians",()=>
            Results.Json(new 
                {
                    Topic = "Features of amphibians ",
                    Notes = new {
                        Fact1 = "Features of amphibians",
                        Divisions = new {
                            Structure = new{
                                Fact1 = "Presence of lungs and gills",
                                Fact2 = "Bilateral symmetry",
                                Fact3 = "Three-layered body plan",
                                Fact4 = "Presence of a pseudocoelom"
                            },
                            Fact2 = "Shape: Cylindrical shape",
                            Fact3 = "Nutrition: Holozoic nutrition",
                            Reproduction = new {
                                Fcat1 = "Asexual reproduction",
                                Fcat2 = "Sexual reproduction"
                            },
                            Distribution = new {
                                Fact1 = "Soil",
                                Fact2 = "Parasites in animals"
                            },
                        }
                    }
                }
            )   
        );

        app.MapGet("/classification/Kingdom-Animalia/Vertebrates/Features-of-reptiles",()=>
            Results.Json(new 
                {
                    Topic = "Features of reptiles ",
                    Notes = new {
                        Fact1 = "Features of reptiles",
                        Divisions = new {
                            Structure = new{
                                Fact1 = "Presence of dry, scaly skin",
                                Fact2 = "Presence of lungs",
                                Fact3 = "Three-chambered heart",
                            },
                            Fact2 = "Shape: Varied shapes",
                            Fact3 = "Nutrition: Holozoic nutrition",
                            Reproduction = new {
                                Fcat1 = "Asexual reproduction",
                                Fcat2 = "Sexual reproduction"
                            },
                            Distribution = new {
                                Fact1 = "Terrestrial environments",
                            },
                        }
                    }
                }
            )   
        );

        app.MapGet("/classification/Kingdom-Animalia/Vertebrates/Features-of-birds",()=>
            Results.Json(new 
                {
                    Topic = "Features of birds ",
                    Notes = new {
                        Fact1 = "Features of birds",
                        Divisions = new {
                            Structure = new{
                                Fact1 = "Presence of feathers",
                                Fact2 = "Presence of beak",
                                Fact3 = "Hollow bones",
                                Fact4 = "Four-chambered heart"
                            },
                            Fact2 = "Shape: Varied shapes",
                            Fact3 = "Nutrition: Holozoic nutrition",
                            Reproduction = new {
                                Fcat1 = "Asexual reproduction",
                                Fcat2 = "Sexual reproduction"
                            },
                            Distribution = new {
                                Fact1 = "All types of environments",
                            },
                        }
                    }
                }
            )   
        );

    app.MapGet("/classification/Kingdom-Animalia/Vertebrates/Features-of-mammals",()=>
            Results.Json(new 
                {
                    Topic = "Features of mammals ",
                    Notes = new {
                        Fact1 = "Features of mammals",
                        Divisions = new {
                            Structure = new{
                                Fact1 = "Presence of hair",
                                Fact2 = "Presence of mammary glands",
                                Fact3 = "Four-chambered heart",
                                Fact4 = "Presence of a pseudocoelom"
                            },
                            Fact2 = "Shape: Varied shapes",
                            Fact3 = "Nutrition: Holozoic nutrition",
                            Reproduction = new {
                                Fcat1 = "Asexual reproduction",
                                Fcat2 = "Sexual reproduction"
                            },
                            Distribution = new {
                                Fact1 = "All types of environments"
                            },
                        }
                    }
                }
            )   
        );

         app.MapGet("/classification/Nomenclature",()=>
            Results.Json(new 
                {
                    Topic = "Nomenclature",
                    Notes = new {
                        Fact1 = "Nomenclature is used to name animals scientifically",
                        Fact2 = "A successful nomenclature system was introduced by a Swedish natural scientist named Carolus Linnaeus in 1753.",
                        Fact3 = "As it contains two epithets, it is known as binomial nomenclature",
                        Fact4 = "The methodology of naming organisms is regulated by the International Code of Botanical Nomenclature (ICBN) and the International Code of Zoological Nomenclature (ICZN).",
                        Fact5 = "Standards of binomial nomenclature:",
                        Divisions = new {
                            Fact1 = "The scientific name of a species is composed of two epithets.",
                            Fact2 = "The first epithet is the genus name, and the second epithet is the specific epithet.",
                            Fact3 = "The species name is given in Latin or Greek.",
                            Fact4 = "The first letter of the genus name is capitalized.",
                        }
                    }
                }
            )   
        );
    }
}
