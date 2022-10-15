//using Liskov_Substitution_Principle_NotIdealCode;

using Liskov_Substitution_Principle_IdealCode;
;

Cloud cloud = new AWS();
cloud.MachineLearning();
(cloud as ITranslatable)?.Translate();

cloud = new Google();
cloud.MachineLearning();
(cloud as ITranslatable)?.Translate();


cloud = new Azure();
cloud.MachineLearning();
(cloud as ITranslatable)?.Translate();
