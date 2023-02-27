using System.Collections.Generic;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<Course> Courses = new List<Course>()
            {
                new Course 
                { 
                    Id = 1, 
                    Code = "INST180", 
                    TitleEng = "Instructional Skills Training", 
                    TitleFre = "Formation aux compétences pédagogiques", 
                    DescEng = "This course introduces a broad array of topics and skills taking participants on a journey from an initial understanding of how adults learn, to establishing a positive learning environment, to planning lessons. From there, the course investigates how to deliver engaging lectures, along with other instructional techniques that promote student success. The course includes a module on assessment strategies that guides participants in the creation of formative and summative assessments. The course concludes by reinforcing the alignment of learning outcomes, learning activities and assessment strategies. Discussion of how instructors can be active supporters of equity, diversity and inclusion is integrated throughout the course.", 
                    DescFre = "Ce cours présente un large éventail de sujets et de compétences emmenant les participants dans un voyage allant d'une compréhension initiale de la façon dont les adultes apprennent, à l'établissement d'un environnement d'apprentissage positif, à la planification des leçons. À partir de là, le cours étudie comment donner des conférences engageantes, ainsi que d'autres techniques pédagogiques qui favorisent la réussite des étudiants. Le cours comprend un module sur les stratégies d'évaluation qui guide les participants dans la création d'évaluations formatives et sommatives. Le cours se termine en renforçant l'alignement des résultats d'apprentissage, des activités d'apprentissage et des stratégies d'évaluation. Une discussion sur la façon dont les instructeurs peuvent être des partisans actifs de l'équité, de la diversité et de l'inclusion est intégrée tout au long du cours.", 
                    LangEng = "English", 
                    LangFre = "Anglais", 
                    Hours = "15", 
                    Active = 1,
                    TypeID = 2,
                    DepartmentID = 8,
                    DisciplineID = 1
                },
                new Course 
                { 
                    Id = 2, 
                    Code = "INST280", 
                    TitleEng = "Basic Instructor Training", 
                    TitleFre = "Formation de base des instructeurs", 
                    DescEng = "The Basic Instructor Training course provides instructors with a combination of theoretical knowledge and practical skills. The course builds on the knowledge and skills acquired in the Instructional Skills Training (IST) course, focusing on the application of theory in practice. In this course, participants have the opportunity to design and deliver mini-lessons while receiving constructive feedback from the instructor and their peers. Specific topics include: learning outcomes, lesson planning, providing feedback, presentation skills, interactive learning activities and assessment strategies.", 
                    DescFre = "Le cours de formation de base des instructeurs offre aux instructeurs une combinaison de connaissances théoriques et de compétences pratiques. Le cours s'appuie sur les connaissances et les compétences acquises dans le cours de formation aux compétences pédagogiques (IST), en se concentrant sur l'application de la théorie dans la pratique. Dans ce cours, les participants ont la possibilité de concevoir et de dispenser des mini-leçons tout en recevant des commentaires constructifs de l'instructeur et de leurs pairs. Les sujets spécifiques comprennent : les résultats d'apprentissage, la planification des leçons, la rétroaction, les techniques de présentation, les activités d'apprentissage interactives et les stratégies d'évaluation.", 
                    LangEng = "English", 
                    LangFre = "Anglais",
                    Hours = "22.5", 
                    Active = 1,
                    TypeID = 2,
                    DepartmentID = 8,
                    DisciplineID = 1
                },
                new Course 
                { 
                    Id = 3, 
                    Code = "ERBS", 
                    TitleEng = "Basics of Ship Stability", 
                    TitleFre = "Bases de la stabilité des navires", 
                    DescEng = "This course is of a series of basic level ship knowledge for Coast Guard employees. You should have completed the first course of the series, Basics of Ship Terminology and Construction, before commencing this course. This course provides basic ship stability terminology and concepts needed to perform activities such as marine pollution assessment, communications with marine personnel, note taking. The stability terminology and concepts discussed in this course are applicable to Pollution Response Vessel (PRV) operations and equipment use. This course won’t provide all the instruction and information necessary to make stability decisions for any vessel. This course doesn’t meet any of the regulations and conventions on the required stability training for vessel operations. Intended as an awareness-level course, the learner will be exposed to terminology and concepts of stability and should encourage discussions on the subject. This course is based on material from the Canadian Coast Guard College and other expert organizations. You should have all the information needed to satisfy the course objectives right here in the course. However, you’re encouraged to seek out other reliable sources to clarify the concepts presented and further support your learning.", 
                    DescFre = "Ce cours est une série de connaissances de base sur les navires pour les employés de la Garde côtière. Vous devriez avoir terminé le premier cours de la série, Bases de la terminologie et de la construction des navires, avant de commencer ce cours. Ce cours fournit la terminologie et les concepts de base de la stabilité des navires nécessaires pour effectuer des activités telles que l'évaluation de la pollution marine, les communications avec le personnel maritime, la prise de notes. La terminologie et les concepts de stabilité abordés dans ce cours s'appliquent aux opérations et à l'utilisation de l'équipement des navires de lutte contre la pollution (PRV). Ce cours ne fournira pas toutes les instructions et informations nécessaires pour prendre des décisions de stabilité pour n'importe quel navire. Ce cours ne respecte aucune des réglementations et conventions sur la formation requise en matière de stabilité pour les opérations de navire. Conçu comme un cours de sensibilisation, l'apprenant sera exposé à la terminologie et aux concepts de stabilité et devrait encourager les discussions sur le sujet. Ce cours est basé sur du matériel du Collège de la Garde côtière canadienne et d'autres organisations spécialisées. Vous devriez avoir toutes les informations nécessaires pour satisfaire les objectifs du cours ici même dans le cours. Cependant, nous vous encourageons à rechercher d'autres sources fiables pour clarifier les concepts présentés et soutenir davantage votre apprentissage.",
                    LangEng = "English", 
                    LangFre = "Anglais",
                    Hours = "10",
                    Active = 1,
                    TypeID = 4,
                    DepartmentID = 7,
                    DisciplineID = 6
                },
                new Course 
                { 
                    Id = 4, 
                    Code = "LOCS", 
                    TitleEng = "Clerk/Storekeeper", 
                    TitleFre = "Commis/magasinier", 
                    DescEng = "This is the first course in the Logistics Development Progression Plan. In this course, candidates develop the knowledge and skills to effectively complete the job tasks that are applicable to the Clerk/Storekeeper. The course will focus on the four areas within the Logistics Department: Hotel Services, Administration, Finance, and Materiel Management.", 
                    DescFre = "Il s'agit de la première formation du Plan de Progression du Développement Logistique. Dans ce cours, les candidats développent les connaissances et les compétences nécessaires pour accomplir efficacement les tâches du poste qui s'appliquent au commis/magasinier. Le cours se concentrera sur les quatre domaines du département logistique : services hôteliers, administration, finances et gestion du matériel.",
                    LangEng = "English", 
                    LangFre = "Anglais",
                    Hours = "42",
                    Active = 1,
                    TypeID = 4,
                    DepartmentID = 7,
                    DisciplineID = 6
                },
                new Course 
                { 
                    Id = 5, 
                    Code = "SCON122", 
                    TitleEng = "Ship Construction 122", 
                    TitleFre = "Construction navale 122", 
                    DescEng = "This course consists of sketching and describing the structural details of a ship’s hull and superstructure, using special shipboard terminology and relating the structure to static and dynamic stresses imposed on a ship. The course also includes the relationship of regulatory bodies in terms of safety and seaworthiness of a vessel. This course covers the knowledge required for various Canadian Coast Guard College and Transport Canada Marine Safety exams such as Naval Architecture and Blueprint Reading & Sketching or Drawing.", 
                    DescFre = "Ce cours consiste à esquisser et à décrire les détails structurels de la coque et de la superstructure d'un navire, en utilisant une terminologie spéciale à bord et en reliant la structure aux contraintes statiques et dynamiques imposées au navire. Le cours comprend également la relation des organismes de réglementation en termes de sécurité et de navigabilité d'un navire. Ce cours couvre les connaissances requises pour divers examens du Collège de la Garde côtière canadienne et de la sécurité maritime de Transports Canada, tels que l'architecture navale et la lecture et l'esquisse de plans ou le dessin.",
                    LangEng = "English", 
                    LangFre = "Anglais",
                    Hours = "144",
                    Active = 1,
                    TypeID = 1,
                    DepartmentID = 2,
                    DisciplineID = 3
                },
                new Course
                {
                    Id = 6,
                    Code = "EKGN222",
                    TitleEng = "Engineering Knowledge General 222",
                    TitleFre = "Connaissances générales en ingénierie 222",
                    DescEng = "This course provides knowledge and information on the construction, theory of operation and proper use of various auxiliary machinery systems. This course covers part of the knowledge required for Transport Canada Marine Safety exams.",
                    DescFre = "Ce cours fournit des connaissances et des informations sur la construction, la théorie du fonctionnement et l'utilisation appropriée de divers systèmes de machines auxiliaires. Ce cours couvre une partie des connaissances requises pour les examens de la sécurité maritime de Transports Canada.",
                    LangEng = "English", 
                    LangFre = "Anglais",
                    Hours = "48",
                    Active = 1,
                    TypeID = 1,
                    DepartmentID = 2,
                    DisciplineID = 3
                },
                new Course
                {
                    Id = 7,
                    Code = "ASTR311",
                    TitleEng = "Nautical Astronomy 311",
                    TitleFre = "Astronomie nautique 311",
                    DescEng = "This course continues with additional theoretical and practical aspects of basic nautical astronomy required to calculate, plot and maintain position and course from any point on the surface of the earth, to any other point on the surface of the earth. This course covers part of the knowledge and skills required for Transport Canada Marine Safety Celestial Navigation 2 (ASTRO-2) exam that is administered by the Canadian Coast Guard College. Upon successful completion of the Canadian Coast Guard Officer Training Plan a credit will be given for Transport Canada Marine Safety (ASTRO-2) exam for the Watchkeeping Mate Certificate, and up to the Master Mariner Certificate.",
                    DescFre = "Ce cours se poursuit avec des aspects théoriques et pratiques supplémentaires de l'astronomie nautique de base nécessaires pour calculer, tracer et maintenir la position et le cap à partir de n'importe quel point de la surface de la terre, vers tout autre point de la surface de la terre. Ce cours couvre une partie des connaissances et des compétences requises pour l'examen de navigation céleste de Transports Canada Sécurité maritime 2 (ASTRO-2) qui est administré par le Collège de la Garde côtière canadienne. Après avoir réussi le plan de formation des officiers de la Garde côtière canadienne, un crédit sera accordé pour l'examen de la sécurité maritime de Transports Canada (ASTRO-2) pour le certificat d'officier de pont de quart, et jusqu'au certificat de capitaine au long cours.",
                    LangEng = "English", 
                    LangFre = "Anglais",
                    Hours = "52",
                    Active = 1,
                    TypeID = 6,
                    DepartmentID = 1,
                    DisciplineID = 2
                },
                new Course
                {
                    Id = 8,
                    Code = "CARG411",
                    TitleEng = "Cargo 411",
                    TitleFre = "Cargaison 411",
                    DescEng = "A continuation of Cargo 111, this course covers various types of cargo vessels and their cargoes including: ships personnel, procedures, documents, shippers, agents and the use of ships data such as general arrangement drawings and capacity plans. This course covers the knowledge and skills required for Marine Safety exam Cargo Level 2 (CG 2) for the Watchkeeping Mate certificate and for the Master Mariner Certificate.",
                    DescFre = "Dans la continuité de Cargo 111, ce cours couvre divers types de navires de charge et leurs cargaisons, notamment : le personnel des navires, les procédures, les documents, les expéditeurs, les agents et l'utilisation des données des navires telles que les schémas d'agencement général et les plans de capacité. Ce cours porte sur les connaissances et les compétences requises pour l'examen de sécurité maritime Cargo Level 2 (CG 2) pour le certificat d'officier de pont de quart et pour le certificat de capitaine au long cours.",
                    LangEng = "English", 
                    LangFre = "Anglais",
                    Hours = "100",
                    Active = 1,
                    TypeID = 6,
                    DepartmentID = 1,
                    DisciplineID = 2
                },
                new Course
                {
                    Id = 9,
                    Code = "MCTSRTE",
                    TitleEng = "Radio Theory and Systems",
                    TitleFre = "Théorie et systèmes radio",
                    DescEng = "You will find this course very useful in the sense that you will see the different modes of communicating with vessels and how they interface with the landline systems through your station and how ships make use of all these systems.  You will also get a basic understanding of radio theory and equipment.",
                    DescFre = "Vous trouverez ce cours très utile dans le sens où vous verrez les différents modes de communication avec les navires et comment ils s'interfacent avec les systèmes de téléphonie fixe via votre station et comment les navires utilisent tous ces systèmes. Vous obtiendrez également une compréhension de base de la théorie et de l'équipement radio.",
                    LangEng = "English", 
                    LangFre = "Anglais",
                    Hours = "5",
                    Active = 1,
                    TypeID = 4,
                    DepartmentID = 6,
                    DisciplineID = 5
                },
                new Course
                {
                    Id = 10,
                    Code = "MCTSMTE",
                    TitleEng = "Meterology",
                    TitleFre = "Météorologie",
                    DescEng = "Weather is a phenomenon that has a major impact on the economics, security and safety of the mariner and is of the utmost interest to them on a daily basis. As an MCTS Officer, weather plays an important role in our daily duties. An MCTS Officer not only provides a two-way communications link between the weather source and the user but also must deal with the safety impacts caused by severe weather conditions.The understanding of basic meteorology allows the MCTS Officer to carry out their daily duties unobstructed by unfamiliar terms.  It also allows the MCTS Officer to be aware of different weather phenomena that can cause potential danger to the mariner.  The ability to decipher weather observations received from vessels also enables the MCTS Officer to have an understanding for current weather conditions in certain geographical areas. All of this information is quite useful in assisting the MCTS Officer in their duties and for the safety of the mariner.",
                    DescFre = "La météo est un phénomène qui a un impact majeur sur l'économie, la sécurité et la sûreté du marin et qui l'intéresse au quotidien. En tant qu'officier des SCTM, la météo joue un rôle important dans nos tâches quotidiennes. Un officier des SCTM fournit non seulement une liaison de communication bidirectionnelle entre la source météorologique et l'utilisateur, mais doit également faire face aux impacts sur la sécurité causés par des conditions météorologiques extrêmes. La compréhension de la météorologie de base permet à l'officier des SCTM de s'acquitter de ses tâches quotidiennes sans être gêné par termes inconnus. Il permet également à l'officier des SCTM d'être au courant des différents phénomènes météorologiques qui peuvent constituer un danger potentiel pour le navigateur. La capacité de déchiffrer les observations météorologiques reçues des navires permet également à l'officier des SCTM de comprendre les conditions météorologiques actuelles dans certaines zones géographiques. Toutes ces informations sont très utiles pour aider l'officier des SCTM dans ses fonctions et pour la sécurité du navigateur.",
                    LangEng = "English", 
                    LangFre = "Anglais",
                    Hours = "6",
                    Active = 1,
                    TypeID = 4,
                    DepartmentID = 6,
                    DisciplineID = 5
                },
                new Course
                {
                    Id = 11,
                    Code = "MATH130",
                    TitleEng = "Mathematics 130",
                    TitleFre = "Mathématiques 130",
                    DescEng = "This course consists of basic differential and integral calculus and its applications for Engineering and Navigation Officer Cadets. This course covers the knowledge and skills required for all Canadian Coast Guard College and Transport Canada Marine Safety exams as identified in the Canadian Coast Guard Officer Training Plan objectives and Transport Canada Marine Safety publication, The Examination and Certification of Seafarers (TP-2293). This course will also provide the required mathematical skills necessary for physics, stability and electro technology courses. It will ensure that the Officer Cadets have a strong background in algebra, trigonometry, common functions, derivatives and integration. This course will ensure that the Officer Cadets have good problem solving skills. This course is a prerequisite for Mathematics 231 and Nautical Astronomy Mathematics 211.",
                    DescFre = "Ce cours comprend le calcul différentiel et intégral de base et ses applications pour les élèves-officiers du génie et de la navigation. Ce cours porte sur les connaissances et les compétences requises pour tous les examens du Collège de la Garde côtière canadienne et de la Sécurité maritime de Transports Canada, tels qu'identifiés dans les objectifs du Plan de formation des officiers de la Garde côtière canadienne et dans la publication de la Sécurité maritime de Transports Canada, L'examen et la certification des gens de mer (TP-2293). Ce cours fournira également les compétences mathématiques requises pour les cours de physique, de stabilité et d'électrotechnique. Il s'assurera que les élèves-officiers possèdent une solide expérience en algèbre, en trigonométrie, en fonctions communes, en dérivées et en intégration. Ce cours garantira que les élèves-officiers possèdent de bonnes compétences en résolution de problèmes. Ce cours est un prérequis pour Mathématiques 231 et Mathématiques d'astronomie nautique 211.",
                    LangEng = "English", 
                    LangFre = "Anglais",
                    Hours = "142",
                    Active = 1,
                    TypeID = 5,
                    DepartmentID = 3,
                    DisciplineID = 1
                },
                new Course
                {
                    Id = 12,
                    Code = "MATH231",
                    TitleEng = "Mathematics 231",
                    TitleFre = "Mathématiques 231",
                    DescEng = "This course consists of basic differential and integral calculus and its applications for Engineering and Navigation Officer Cadets. This course covers the knowledge and skills required for all Canadian Coast Guard College and Transport Canada Marine Safety exams as identified in the Canadian Coast Guard Officer Training Plan objectives and Transport Canada Marine Safety publication, The Examination and Certification of Seafarers (TP-2293). This course will also provide the required mathematical skills necessary for physics, stability and electro technology courses. It will ensure that the Officer Cadets have a strong background in algebra, trigonometry, common functions, derivatives and integration. This course will ensure that the Officer Cadets have good problem solving skills.",
                    DescFre = "Ce cours étudie le calcul différentiel et le calcul intégral de base, ainsi que leurs applications pour les élèves-officiers en mécanique et en navigation. Il couvre les connaissances et les compétences exigées en vue de tous les examens du CGCC et de la Sécurité maritime de Transports Canada (SMTC), telles qu’identifiées dans les objectifs du PFO et dans la publication de SMTC, Examens des gens de mer et délivrance des brevets et certificats (TP 2293). Le cours procure également les compétences en mathématiques nécessaires aux cours de physique, de stabilité et d’électrotechnologie. Il assure aux élèves-officiers de détenir de solides connaissances de base en algèbre, en trigonométrie, sur les fonctions communes, les dérivées et l’intégration. De plus, il leur fournit des compétences en résolution de problèmes. ",
                    LangEng = "French", 
                    LangFre = "Français",
                    Hours = "48",
                    Active = 1,
                    TypeID = 5,
                    DepartmentID = 3,
                    DisciplineID = 2
                },
                new Course
                {
                    Id = 13,
                    Code = "IFTT-060",
                    TitleEng = "Installation Fundamentals and Techniques Course",
                    TitleFre = "Cours Fondamentaux et techniques d'installation",
                    DescEng = "Description goes here",
                    DescFre = "La description irait ici",
                    LangEng = "English", 
                    LangFre = "Anglais",
                    Hours = "20",
                    Active = 1,
                    TypeID = 4,
                    DepartmentID = 5,
                    DisciplineID = 4
                },
                new Course
                {
                    Id = 14,
                    Code = "BMER-060",
                    TitleEng = "BridgeMaster - E Radar Maintenance Course",
                    TitleFre = "BridgeMaster - Cours de maintenance des radars E",
                    DescEng = "Description goes here",
                    DescFre = "La description irait ici",
                    LangEng = "English", 
                    LangFre = "Anglais",
                    Hours = "20",
                    Active = 1,
                    TypeID = 4,
                    DepartmentID = 5,
                    DisciplineID = 4
                },
            };
    }
}
