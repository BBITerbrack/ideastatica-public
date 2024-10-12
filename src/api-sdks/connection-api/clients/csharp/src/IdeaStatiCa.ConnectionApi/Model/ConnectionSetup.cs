/*
 * Connection Rest API 1.0
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = IdeaStatiCa.ConnectionApi.Client.OpenAPIDateConverter;

namespace IdeaStatiCa.ConnectionApi.Model
{
    /// <summary>
    /// ConnectionSetup
    /// </summary>
    [DataContract(Name = "ConnectionSetup")]
    public partial class ConnectionSetup : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets WeldEvaluationData
        /// </summary>
        [DataMember(Name = "weldEvaluationData", EmitDefaultValue = false)]
        public WeldEvaluation? WeldEvaluationData { get; set; }

        /// <summary>
        /// Gets or Sets ApplyConeBreakoutCheck
        /// </summary>
        [DataMember(Name = "applyConeBreakoutCheck", EmitDefaultValue = false)]
        public ConeBreakoutCheckType? ApplyConeBreakoutCheck { get; set; }

        /// <summary>
        /// Gets or Sets CrtCompCheckIS
        /// </summary>
        [DataMember(Name = "crtCompCheckIS", EmitDefaultValue = false)]
        public CrtCompCheckIS? CrtCompCheckIS { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionSetup" /> class.
        /// </summary>
        /// <param name="steelSetup">ISteelSetup.</param>
        /// <param name="concreteSetup">concreteSetup.</param>
        /// <param name="stopAtLimitStrain">Stop analysis when the limit strain is reached..</param>
        /// <param name="weldEvaluationData">weldEvaluationData.</param>
        /// <param name="checkDetailing">Perform check of bolt positions.</param>
        /// <param name="applyConeBreakoutCheck">applyConeBreakoutCheck.</param>
        /// <param name="pretensionForceFpc">Pretension force fpc &#x3D; k * fub * As.</param>
        /// <param name="gammaInst">Partial safety factor of instalation safety.</param>
        /// <param name="gammaC">Partial safety factor of concrete.</param>
        /// <param name="gammaM3">Preloaded bolts safety factor.</param>
        /// <param name="anchorLengthForStiffness">Length of anchor to define the anchor stiffness in analysis model, as a multiple of anchor diameter (E A /n * [d]).</param>
        /// <param name="jointBetaFactor">Joint coefficient βj - Used for Fjd calculation.</param>
        /// <param name="effectiveAreaStressCoeff">Effective area is taken from intersection of stress area and area of joined items according to EN1993-1-8 art. 6.2.5.</param>
        /// <param name="effectiveAreaStressCoeffAISC">Effective area stress coefficient - Concrete loaded area: Stress cut-off is set for AISC.</param>
        /// <param name="frictionCoefficient">Coefficient of friction between base plate and concrete block.</param>
        /// <param name="limitPlasticStrain">Limit of plastic strain used in 2D plate element check.</param>
        /// <param name="limitDeformation">Limit deformation on closed sections.</param>
        /// <param name="limitDeformationCheck">Limit deformation on closed sections check or not.</param>
        /// <param name="analysisGNL">Analysis with GNL.</param>
        /// <param name="analysisAllGNL">Analysis with All GNL.</param>
        /// <param name="warnPlasticStrain">Warning plastic strain.</param>
        /// <param name="warnCheckLevel">Warning check level.</param>
        /// <param name="optimalCheckLevel">Optimal check level.</param>
        /// <param name="distanceBetweenBolts">Limit distance between bolts as a multiple of bolt diameter.</param>
        /// <param name="distanceDiameterBetweenBP">Anchor pitch.</param>
        /// <param name="distanceBetweenBoltsEdge">Limit distance between bolt and plate edge as a multiple of bolt diameter.</param>
        /// <param name="bearingAngle">Load distribution angle of concrete block in calculation of factor Kj.</param>
        /// <param name="decreasingFtrd">Decreasing Ftrd of anchors. Worse quality influence.</param>
        /// <param name="bracedSystem">Consider the frame system as braced for stiffness calculation. Braced system reduces horizontal displacements..</param>
        /// <param name="bearingCheck">Apply bearing check including αb.</param>
        /// <param name="applyBetapInfluence">Apply βp influence in bolt shear resistance. ΕΝ 1993-1-8 chapter 3.6.1 (12).</param>
        /// <param name="memberLengthRatio">A multiple of cross-section height to determine the default length of member.</param>
        /// <param name="divisionOfSurfaceOfCHS">Number of straight lines to substitute circle of circular tube in analysis model.</param>
        /// <param name="divisionOfArcsOfRHS">Number of straight lines to substitute corner arc of rectangular tubes in analysis model.</param>
        /// <param name="numElement">Ratio of length of decisive plate edge and Elements on edge count determines the average size of mesh element.</param>
        /// <param name="numberIterations">More iterations helps to find better solutions in contact elements but increases calculation time.</param>
        /// <param name="mdiv">Number of iteration steps to evaluate analysis divergence.</param>
        /// <param name="minSize">Minimal size of generated finite mesh element.</param>
        /// <param name="maxSize">Maximal size of generated finite mesh element.</param>
        /// <param name="numElementRhs">Number of mesh elements in RHS height.</param>
        /// <param name="numElementPlate">Number of mesh elements on plates.</param>
        /// <param name="rigidBP">True if rigid base plate is considered.</param>
        /// <param name="alphaCC">Long-term effect on fcd.</param>
        /// <param name="crackedConcrete">True if cracked concrete is considered.</param>
        /// <param name="developedFillers">True if developed fillers is considered.</param>
        /// <param name="deformationBoltHole">True if bolt hole deformation is considered.</param>
        /// <param name="extensionLengthRationOpenSections">ExtensionLengthRationOpenSections.</param>
        /// <param name="extensionLengthRationCloseSections">ExtensionLengthRationCloseSections.</param>
        /// <param name="factorPreloadBolt">FactorPreloadBolt.</param>
        /// <param name="baseMetalCapacity">BaseMetalCapacity.</param>
        /// <param name="applyBearingCheck">ApplyBearingCheck.</param>
        /// <param name="frictionCoefficientPbolt">Friction factor of slip-resistant joint.</param>
        /// <param name="crtCompCheckIS">crtCompCheckIS.</param>
        /// <param name="boltMaxGripLengthCoeff">Max value of bolt grip.</param>
        /// <param name="fatigueSectionOffset">Fatigue section Offset &#x3D; FatigueSectionOffset x Legsize.</param>
        /// <param name="condensedElementLengthFactor">Condensed element length factor (CEF). Condensed beam legth &#x3D; maxCssSize * CEF.</param>
        /// <param name="gammaMu">Partial safety factor for Horizontal tying.</param>
        /// <param name="hssLimitPlasticStrain">Limit plastic strain for high strength steel.</param>
        public ConnectionSetup(Object steelSetup = default(Object), ConcreteSetup concreteSetup = default(ConcreteSetup), bool stopAtLimitStrain = default(bool), WeldEvaluation? weldEvaluationData = default(WeldEvaluation?), bool checkDetailing = default(bool), ConeBreakoutCheckType? applyConeBreakoutCheck = default(ConeBreakoutCheckType?), double pretensionForceFpc = default(double), double gammaInst = default(double), double gammaC = default(double), double gammaM3 = default(double), int anchorLengthForStiffness = default(int), double jointBetaFactor = default(double), double effectiveAreaStressCoeff = default(double), double effectiveAreaStressCoeffAISC = default(double), double frictionCoefficient = default(double), double limitPlasticStrain = default(double), double limitDeformation = default(double), bool limitDeformationCheck = default(bool), bool analysisGNL = default(bool), bool analysisAllGNL = default(bool), double warnPlasticStrain = default(double), double warnCheckLevel = default(double), double optimalCheckLevel = default(double), double distanceBetweenBolts = default(double), double distanceDiameterBetweenBP = default(double), double distanceBetweenBoltsEdge = default(double), double bearingAngle = default(double), double decreasingFtrd = default(double), bool bracedSystem = default(bool), bool bearingCheck = default(bool), bool applyBetapInfluence = default(bool), double memberLengthRatio = default(double), int divisionOfSurfaceOfCHS = default(int), int divisionOfArcsOfRHS = default(int), int numElement = default(int), int numberIterations = default(int), int mdiv = default(int), double minSize = default(double), double maxSize = default(double), int numElementRhs = default(int), int numElementPlate = default(int), bool rigidBP = default(bool), double alphaCC = default(double), bool crackedConcrete = default(bool), bool developedFillers = default(bool), bool deformationBoltHole = default(bool), double extensionLengthRationOpenSections = default(double), double extensionLengthRationCloseSections = default(double), double factorPreloadBolt = default(double), bool baseMetalCapacity = default(bool), bool applyBearingCheck = default(bool), double frictionCoefficientPbolt = default(double), CrtCompCheckIS? crtCompCheckIS = default(CrtCompCheckIS?), double boltMaxGripLengthCoeff = default(double), double fatigueSectionOffset = default(double), double condensedElementLengthFactor = default(double), double gammaMu = default(double), double hssLimitPlasticStrain = default(double))
        {
            this.SteelSetup = steelSetup;
            this.ConcreteSetup = concreteSetup;
            this.StopAtLimitStrain = stopAtLimitStrain;
            this.WeldEvaluationData = weldEvaluationData;
            this.CheckDetailing = checkDetailing;
            this.ApplyConeBreakoutCheck = applyConeBreakoutCheck;
            this.PretensionForceFpc = pretensionForceFpc;
            this.GammaInst = gammaInst;
            this.GammaC = gammaC;
            this.GammaM3 = gammaM3;
            this.AnchorLengthForStiffness = anchorLengthForStiffness;
            this.JointBetaFactor = jointBetaFactor;
            this.EffectiveAreaStressCoeff = effectiveAreaStressCoeff;
            this.EffectiveAreaStressCoeffAISC = effectiveAreaStressCoeffAISC;
            this.FrictionCoefficient = frictionCoefficient;
            this.LimitPlasticStrain = limitPlasticStrain;
            this.LimitDeformation = limitDeformation;
            this.LimitDeformationCheck = limitDeformationCheck;
            this.AnalysisGNL = analysisGNL;
            this.AnalysisAllGNL = analysisAllGNL;
            this.WarnPlasticStrain = warnPlasticStrain;
            this.WarnCheckLevel = warnCheckLevel;
            this.OptimalCheckLevel = optimalCheckLevel;
            this.DistanceBetweenBolts = distanceBetweenBolts;
            this.DistanceDiameterBetweenBP = distanceDiameterBetweenBP;
            this.DistanceBetweenBoltsEdge = distanceBetweenBoltsEdge;
            this.BearingAngle = bearingAngle;
            this.DecreasingFtrd = decreasingFtrd;
            this.BracedSystem = bracedSystem;
            this.BearingCheck = bearingCheck;
            this.ApplyBetapInfluence = applyBetapInfluence;
            this.MemberLengthRatio = memberLengthRatio;
            this.DivisionOfSurfaceOfCHS = divisionOfSurfaceOfCHS;
            this.DivisionOfArcsOfRHS = divisionOfArcsOfRHS;
            this.NumElement = numElement;
            this.NumberIterations = numberIterations;
            this.Mdiv = mdiv;
            this.MinSize = minSize;
            this.MaxSize = maxSize;
            this.NumElementRhs = numElementRhs;
            this.NumElementPlate = numElementPlate;
            this.RigidBP = rigidBP;
            this.AlphaCC = alphaCC;
            this.CrackedConcrete = crackedConcrete;
            this.DevelopedFillers = developedFillers;
            this.DeformationBoltHole = deformationBoltHole;
            this.ExtensionLengthRationOpenSections = extensionLengthRationOpenSections;
            this.ExtensionLengthRationCloseSections = extensionLengthRationCloseSections;
            this.FactorPreloadBolt = factorPreloadBolt;
            this.BaseMetalCapacity = baseMetalCapacity;
            this.ApplyBearingCheck = applyBearingCheck;
            this.FrictionCoefficientPbolt = frictionCoefficientPbolt;
            this.CrtCompCheckIS = crtCompCheckIS;
            this.BoltMaxGripLengthCoeff = boltMaxGripLengthCoeff;
            this.FatigueSectionOffset = fatigueSectionOffset;
            this.CondensedElementLengthFactor = condensedElementLengthFactor;
            this.GammaMu = gammaMu;
            this.HssLimitPlasticStrain = hssLimitPlasticStrain;
        }

        /// <summary>
        /// ISteelSetup
        /// </summary>
        /// <value>ISteelSetup</value>
        [DataMember(Name = "steelSetup", EmitDefaultValue = false)]
        public Object SteelSetup { get; set; }

        /// <summary>
        /// Gets or Sets ConcreteSetup
        /// </summary>
        [DataMember(Name = "concreteSetup", EmitDefaultValue = false)]
        public ConcreteSetup ConcreteSetup { get; set; }

        /// <summary>
        /// Stop analysis when the limit strain is reached.
        /// </summary>
        /// <value>Stop analysis when the limit strain is reached.</value>
        [DataMember(Name = "stopAtLimitStrain", EmitDefaultValue = true)]
        public bool StopAtLimitStrain { get; set; }

        /// <summary>
        /// Perform check of bolt positions
        /// </summary>
        /// <value>Perform check of bolt positions</value>
        [DataMember(Name = "checkDetailing", EmitDefaultValue = true)]
        public bool CheckDetailing { get; set; }

        /// <summary>
        /// Pretension force fpc &#x3D; k * fub * As
        /// </summary>
        /// <value>Pretension force fpc &#x3D; k * fub * As</value>
        [DataMember(Name = "pretensionForceFpc", EmitDefaultValue = false)]
        public double PretensionForceFpc { get; set; }

        /// <summary>
        /// Partial safety factor of instalation safety
        /// </summary>
        /// <value>Partial safety factor of instalation safety</value>
        [DataMember(Name = "gammaInst", EmitDefaultValue = false)]
        public double GammaInst { get; set; }

        /// <summary>
        /// Partial safety factor of concrete
        /// </summary>
        /// <value>Partial safety factor of concrete</value>
        [DataMember(Name = "gammaC", EmitDefaultValue = false)]
        public double GammaC { get; set; }

        /// <summary>
        /// Preloaded bolts safety factor
        /// </summary>
        /// <value>Preloaded bolts safety factor</value>
        [DataMember(Name = "gammaM3", EmitDefaultValue = false)]
        public double GammaM3 { get; set; }

        /// <summary>
        /// Length of anchor to define the anchor stiffness in analysis model, as a multiple of anchor diameter (E A /n * [d])
        /// </summary>
        /// <value>Length of anchor to define the anchor stiffness in analysis model, as a multiple of anchor diameter (E A /n * [d])</value>
        [DataMember(Name = "anchorLengthForStiffness", EmitDefaultValue = false)]
        public int AnchorLengthForStiffness { get; set; }

        /// <summary>
        /// Joint coefficient βj - Used for Fjd calculation
        /// </summary>
        /// <value>Joint coefficient βj - Used for Fjd calculation</value>
        [DataMember(Name = "jointBetaFactor", EmitDefaultValue = false)]
        public double JointBetaFactor { get; set; }

        /// <summary>
        /// Effective area is taken from intersection of stress area and area of joined items according to EN1993-1-8 art. 6.2.5
        /// </summary>
        /// <value>Effective area is taken from intersection of stress area and area of joined items according to EN1993-1-8 art. 6.2.5</value>
        [DataMember(Name = "effectiveAreaStressCoeff", EmitDefaultValue = false)]
        public double EffectiveAreaStressCoeff { get; set; }

        /// <summary>
        /// Effective area stress coefficient - Concrete loaded area: Stress cut-off is set for AISC
        /// </summary>
        /// <value>Effective area stress coefficient - Concrete loaded area: Stress cut-off is set for AISC</value>
        [DataMember(Name = "effectiveAreaStressCoeffAISC", EmitDefaultValue = false)]
        public double EffectiveAreaStressCoeffAISC { get; set; }

        /// <summary>
        /// Coefficient of friction between base plate and concrete block
        /// </summary>
        /// <value>Coefficient of friction between base plate and concrete block</value>
        [DataMember(Name = "frictionCoefficient", EmitDefaultValue = false)]
        public double FrictionCoefficient { get; set; }

        /// <summary>
        /// Limit of plastic strain used in 2D plate element check
        /// </summary>
        /// <value>Limit of plastic strain used in 2D plate element check</value>
        [DataMember(Name = "limitPlasticStrain", EmitDefaultValue = false)]
        public double LimitPlasticStrain { get; set; }

        /// <summary>
        /// Limit deformation on closed sections
        /// </summary>
        /// <value>Limit deformation on closed sections</value>
        [DataMember(Name = "limitDeformation", EmitDefaultValue = false)]
        public double LimitDeformation { get; set; }

        /// <summary>
        /// Limit deformation on closed sections check or not
        /// </summary>
        /// <value>Limit deformation on closed sections check or not</value>
        [DataMember(Name = "limitDeformationCheck", EmitDefaultValue = true)]
        public bool LimitDeformationCheck { get; set; }

        /// <summary>
        /// Analysis with GNL
        /// </summary>
        /// <value>Analysis with GNL</value>
        [DataMember(Name = "analysisGNL", EmitDefaultValue = true)]
        public bool AnalysisGNL { get; set; }

        /// <summary>
        /// Analysis with All GNL
        /// </summary>
        /// <value>Analysis with All GNL</value>
        [DataMember(Name = "analysisAllGNL", EmitDefaultValue = true)]
        public bool AnalysisAllGNL { get; set; }

        /// <summary>
        /// Warning plastic strain
        /// </summary>
        /// <value>Warning plastic strain</value>
        [DataMember(Name = "warnPlasticStrain", EmitDefaultValue = false)]
        public double WarnPlasticStrain { get; set; }

        /// <summary>
        /// Warning check level
        /// </summary>
        /// <value>Warning check level</value>
        [DataMember(Name = "warnCheckLevel", EmitDefaultValue = false)]
        public double WarnCheckLevel { get; set; }

        /// <summary>
        /// Optimal check level
        /// </summary>
        /// <value>Optimal check level</value>
        [DataMember(Name = "optimalCheckLevel", EmitDefaultValue = false)]
        public double OptimalCheckLevel { get; set; }

        /// <summary>
        /// Limit distance between bolts as a multiple of bolt diameter
        /// </summary>
        /// <value>Limit distance between bolts as a multiple of bolt diameter</value>
        [DataMember(Name = "distanceBetweenBolts", EmitDefaultValue = false)]
        public double DistanceBetweenBolts { get; set; }

        /// <summary>
        /// Anchor pitch
        /// </summary>
        /// <value>Anchor pitch</value>
        [DataMember(Name = "distanceDiameterBetweenBP", EmitDefaultValue = false)]
        public double DistanceDiameterBetweenBP { get; set; }

        /// <summary>
        /// Limit distance between bolt and plate edge as a multiple of bolt diameter
        /// </summary>
        /// <value>Limit distance between bolt and plate edge as a multiple of bolt diameter</value>
        [DataMember(Name = "distanceBetweenBoltsEdge", EmitDefaultValue = false)]
        public double DistanceBetweenBoltsEdge { get; set; }

        /// <summary>
        /// Load distribution angle of concrete block in calculation of factor Kj
        /// </summary>
        /// <value>Load distribution angle of concrete block in calculation of factor Kj</value>
        [DataMember(Name = "bearingAngle", EmitDefaultValue = false)]
        public double BearingAngle { get; set; }

        /// <summary>
        /// Decreasing Ftrd of anchors. Worse quality influence
        /// </summary>
        /// <value>Decreasing Ftrd of anchors. Worse quality influence</value>
        [DataMember(Name = "decreasingFtrd", EmitDefaultValue = false)]
        public double DecreasingFtrd { get; set; }

        /// <summary>
        /// Consider the frame system as braced for stiffness calculation. Braced system reduces horizontal displacements.
        /// </summary>
        /// <value>Consider the frame system as braced for stiffness calculation. Braced system reduces horizontal displacements.</value>
        [DataMember(Name = "bracedSystem", EmitDefaultValue = true)]
        public bool BracedSystem { get; set; }

        /// <summary>
        /// Apply bearing check including αb
        /// </summary>
        /// <value>Apply bearing check including αb</value>
        [DataMember(Name = "bearingCheck", EmitDefaultValue = true)]
        public bool BearingCheck { get; set; }

        /// <summary>
        /// Apply βp influence in bolt shear resistance. ΕΝ 1993-1-8 chapter 3.6.1 (12)
        /// </summary>
        /// <value>Apply βp influence in bolt shear resistance. ΕΝ 1993-1-8 chapter 3.6.1 (12)</value>
        [DataMember(Name = "applyBetapInfluence", EmitDefaultValue = true)]
        public bool ApplyBetapInfluence { get; set; }

        /// <summary>
        /// A multiple of cross-section height to determine the default length of member
        /// </summary>
        /// <value>A multiple of cross-section height to determine the default length of member</value>
        [DataMember(Name = "memberLengthRatio", EmitDefaultValue = false)]
        public double MemberLengthRatio { get; set; }

        /// <summary>
        /// Number of straight lines to substitute circle of circular tube in analysis model
        /// </summary>
        /// <value>Number of straight lines to substitute circle of circular tube in analysis model</value>
        [DataMember(Name = "divisionOfSurfaceOfCHS", EmitDefaultValue = false)]
        public int DivisionOfSurfaceOfCHS { get; set; }

        /// <summary>
        /// Number of straight lines to substitute corner arc of rectangular tubes in analysis model
        /// </summary>
        /// <value>Number of straight lines to substitute corner arc of rectangular tubes in analysis model</value>
        [DataMember(Name = "divisionOfArcsOfRHS", EmitDefaultValue = false)]
        public int DivisionOfArcsOfRHS { get; set; }

        /// <summary>
        /// Ratio of length of decisive plate edge and Elements on edge count determines the average size of mesh element
        /// </summary>
        /// <value>Ratio of length of decisive plate edge and Elements on edge count determines the average size of mesh element</value>
        [DataMember(Name = "numElement", EmitDefaultValue = false)]
        public int NumElement { get; set; }

        /// <summary>
        /// More iterations helps to find better solutions in contact elements but increases calculation time
        /// </summary>
        /// <value>More iterations helps to find better solutions in contact elements but increases calculation time</value>
        [DataMember(Name = "numberIterations", EmitDefaultValue = false)]
        public int NumberIterations { get; set; }

        /// <summary>
        /// Number of iteration steps to evaluate analysis divergence
        /// </summary>
        /// <value>Number of iteration steps to evaluate analysis divergence</value>
        [DataMember(Name = "mdiv", EmitDefaultValue = false)]
        public int Mdiv { get; set; }

        /// <summary>
        /// Minimal size of generated finite mesh element
        /// </summary>
        /// <value>Minimal size of generated finite mesh element</value>
        [DataMember(Name = "minSize", EmitDefaultValue = false)]
        public double MinSize { get; set; }

        /// <summary>
        /// Maximal size of generated finite mesh element
        /// </summary>
        /// <value>Maximal size of generated finite mesh element</value>
        [DataMember(Name = "maxSize", EmitDefaultValue = false)]
        public double MaxSize { get; set; }

        /// <summary>
        /// Number of mesh elements in RHS height
        /// </summary>
        /// <value>Number of mesh elements in RHS height</value>
        [DataMember(Name = "numElementRhs", EmitDefaultValue = false)]
        public int NumElementRhs { get; set; }

        /// <summary>
        /// Number of mesh elements on plates
        /// </summary>
        /// <value>Number of mesh elements on plates</value>
        [DataMember(Name = "numElementPlate", EmitDefaultValue = false)]
        public int NumElementPlate { get; set; }

        /// <summary>
        /// True if rigid base plate is considered
        /// </summary>
        /// <value>True if rigid base plate is considered</value>
        [DataMember(Name = "rigidBP", EmitDefaultValue = true)]
        public bool RigidBP { get; set; }

        /// <summary>
        /// Long-term effect on fcd
        /// </summary>
        /// <value>Long-term effect on fcd</value>
        [DataMember(Name = "alphaCC", EmitDefaultValue = false)]
        public double AlphaCC { get; set; }

        /// <summary>
        /// True if cracked concrete is considered
        /// </summary>
        /// <value>True if cracked concrete is considered</value>
        [DataMember(Name = "crackedConcrete", EmitDefaultValue = true)]
        public bool CrackedConcrete { get; set; }

        /// <summary>
        /// True if developed fillers is considered
        /// </summary>
        /// <value>True if developed fillers is considered</value>
        [DataMember(Name = "developedFillers", EmitDefaultValue = true)]
        public bool DevelopedFillers { get; set; }

        /// <summary>
        /// True if bolt hole deformation is considered
        /// </summary>
        /// <value>True if bolt hole deformation is considered</value>
        [DataMember(Name = "deformationBoltHole", EmitDefaultValue = true)]
        public bool DeformationBoltHole { get; set; }

        /// <summary>
        /// ExtensionLengthRationOpenSections
        /// </summary>
        /// <value>ExtensionLengthRationOpenSections</value>
        [DataMember(Name = "extensionLengthRationOpenSections", EmitDefaultValue = false)]
        public double ExtensionLengthRationOpenSections { get; set; }

        /// <summary>
        /// ExtensionLengthRationCloseSections
        /// </summary>
        /// <value>ExtensionLengthRationCloseSections</value>
        [DataMember(Name = "extensionLengthRationCloseSections", EmitDefaultValue = false)]
        public double ExtensionLengthRationCloseSections { get; set; }

        /// <summary>
        /// FactorPreloadBolt
        /// </summary>
        /// <value>FactorPreloadBolt</value>
        [DataMember(Name = "factorPreloadBolt", EmitDefaultValue = false)]
        public double FactorPreloadBolt { get; set; }

        /// <summary>
        /// BaseMetalCapacity
        /// </summary>
        /// <value>BaseMetalCapacity</value>
        [DataMember(Name = "baseMetalCapacity", EmitDefaultValue = true)]
        public bool BaseMetalCapacity { get; set; }

        /// <summary>
        /// ApplyBearingCheck
        /// </summary>
        /// <value>ApplyBearingCheck</value>
        [DataMember(Name = "applyBearingCheck", EmitDefaultValue = true)]
        public bool ApplyBearingCheck { get; set; }

        /// <summary>
        /// Friction factor of slip-resistant joint
        /// </summary>
        /// <value>Friction factor of slip-resistant joint</value>
        [DataMember(Name = "frictionCoefficientPbolt", EmitDefaultValue = false)]
        public double FrictionCoefficientPbolt { get; set; }

        /// <summary>
        /// Max value of bolt grip
        /// </summary>
        /// <value>Max value of bolt grip</value>
        [DataMember(Name = "boltMaxGripLengthCoeff", EmitDefaultValue = false)]
        public double BoltMaxGripLengthCoeff { get; set; }

        /// <summary>
        /// Fatigue section Offset &#x3D; FatigueSectionOffset x Legsize
        /// </summary>
        /// <value>Fatigue section Offset &#x3D; FatigueSectionOffset x Legsize</value>
        [DataMember(Name = "fatigueSectionOffset", EmitDefaultValue = false)]
        public double FatigueSectionOffset { get; set; }

        /// <summary>
        /// Condensed element length factor (CEF). Condensed beam legth &#x3D; maxCssSize * CEF
        /// </summary>
        /// <value>Condensed element length factor (CEF). Condensed beam legth &#x3D; maxCssSize * CEF</value>
        [DataMember(Name = "condensedElementLengthFactor", EmitDefaultValue = false)]
        public double CondensedElementLengthFactor { get; set; }

        /// <summary>
        /// Partial safety factor for Horizontal tying
        /// </summary>
        /// <value>Partial safety factor for Horizontal tying</value>
        [DataMember(Name = "gammaMu", EmitDefaultValue = false)]
        public double GammaMu { get; set; }

        /// <summary>
        /// Limit plastic strain for high strength steel
        /// </summary>
        /// <value>Limit plastic strain for high strength steel</value>
        [DataMember(Name = "hssLimitPlasticStrain", EmitDefaultValue = false)]
        public double HssLimitPlasticStrain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectionSetup {\n");
            sb.Append("  SteelSetup: ").Append(SteelSetup).Append("\n");
            sb.Append("  ConcreteSetup: ").Append(ConcreteSetup).Append("\n");
            sb.Append("  StopAtLimitStrain: ").Append(StopAtLimitStrain).Append("\n");
            sb.Append("  WeldEvaluationData: ").Append(WeldEvaluationData).Append("\n");
            sb.Append("  CheckDetailing: ").Append(CheckDetailing).Append("\n");
            sb.Append("  ApplyConeBreakoutCheck: ").Append(ApplyConeBreakoutCheck).Append("\n");
            sb.Append("  PretensionForceFpc: ").Append(PretensionForceFpc).Append("\n");
            sb.Append("  GammaInst: ").Append(GammaInst).Append("\n");
            sb.Append("  GammaC: ").Append(GammaC).Append("\n");
            sb.Append("  GammaM3: ").Append(GammaM3).Append("\n");
            sb.Append("  AnchorLengthForStiffness: ").Append(AnchorLengthForStiffness).Append("\n");
            sb.Append("  JointBetaFactor: ").Append(JointBetaFactor).Append("\n");
            sb.Append("  EffectiveAreaStressCoeff: ").Append(EffectiveAreaStressCoeff).Append("\n");
            sb.Append("  EffectiveAreaStressCoeffAISC: ").Append(EffectiveAreaStressCoeffAISC).Append("\n");
            sb.Append("  FrictionCoefficient: ").Append(FrictionCoefficient).Append("\n");
            sb.Append("  LimitPlasticStrain: ").Append(LimitPlasticStrain).Append("\n");
            sb.Append("  LimitDeformation: ").Append(LimitDeformation).Append("\n");
            sb.Append("  LimitDeformationCheck: ").Append(LimitDeformationCheck).Append("\n");
            sb.Append("  AnalysisGNL: ").Append(AnalysisGNL).Append("\n");
            sb.Append("  AnalysisAllGNL: ").Append(AnalysisAllGNL).Append("\n");
            sb.Append("  WarnPlasticStrain: ").Append(WarnPlasticStrain).Append("\n");
            sb.Append("  WarnCheckLevel: ").Append(WarnCheckLevel).Append("\n");
            sb.Append("  OptimalCheckLevel: ").Append(OptimalCheckLevel).Append("\n");
            sb.Append("  DistanceBetweenBolts: ").Append(DistanceBetweenBolts).Append("\n");
            sb.Append("  DistanceDiameterBetweenBP: ").Append(DistanceDiameterBetweenBP).Append("\n");
            sb.Append("  DistanceBetweenBoltsEdge: ").Append(DistanceBetweenBoltsEdge).Append("\n");
            sb.Append("  BearingAngle: ").Append(BearingAngle).Append("\n");
            sb.Append("  DecreasingFtrd: ").Append(DecreasingFtrd).Append("\n");
            sb.Append("  BracedSystem: ").Append(BracedSystem).Append("\n");
            sb.Append("  BearingCheck: ").Append(BearingCheck).Append("\n");
            sb.Append("  ApplyBetapInfluence: ").Append(ApplyBetapInfluence).Append("\n");
            sb.Append("  MemberLengthRatio: ").Append(MemberLengthRatio).Append("\n");
            sb.Append("  DivisionOfSurfaceOfCHS: ").Append(DivisionOfSurfaceOfCHS).Append("\n");
            sb.Append("  DivisionOfArcsOfRHS: ").Append(DivisionOfArcsOfRHS).Append("\n");
            sb.Append("  NumElement: ").Append(NumElement).Append("\n");
            sb.Append("  NumberIterations: ").Append(NumberIterations).Append("\n");
            sb.Append("  Mdiv: ").Append(Mdiv).Append("\n");
            sb.Append("  MinSize: ").Append(MinSize).Append("\n");
            sb.Append("  MaxSize: ").Append(MaxSize).Append("\n");
            sb.Append("  NumElementRhs: ").Append(NumElementRhs).Append("\n");
            sb.Append("  NumElementPlate: ").Append(NumElementPlate).Append("\n");
            sb.Append("  RigidBP: ").Append(RigidBP).Append("\n");
            sb.Append("  AlphaCC: ").Append(AlphaCC).Append("\n");
            sb.Append("  CrackedConcrete: ").Append(CrackedConcrete).Append("\n");
            sb.Append("  DevelopedFillers: ").Append(DevelopedFillers).Append("\n");
            sb.Append("  DeformationBoltHole: ").Append(DeformationBoltHole).Append("\n");
            sb.Append("  ExtensionLengthRationOpenSections: ").Append(ExtensionLengthRationOpenSections).Append("\n");
            sb.Append("  ExtensionLengthRationCloseSections: ").Append(ExtensionLengthRationCloseSections).Append("\n");
            sb.Append("  FactorPreloadBolt: ").Append(FactorPreloadBolt).Append("\n");
            sb.Append("  BaseMetalCapacity: ").Append(BaseMetalCapacity).Append("\n");
            sb.Append("  ApplyBearingCheck: ").Append(ApplyBearingCheck).Append("\n");
            sb.Append("  FrictionCoefficientPbolt: ").Append(FrictionCoefficientPbolt).Append("\n");
            sb.Append("  CrtCompCheckIS: ").Append(CrtCompCheckIS).Append("\n");
            sb.Append("  BoltMaxGripLengthCoeff: ").Append(BoltMaxGripLengthCoeff).Append("\n");
            sb.Append("  FatigueSectionOffset: ").Append(FatigueSectionOffset).Append("\n");
            sb.Append("  CondensedElementLengthFactor: ").Append(CondensedElementLengthFactor).Append("\n");
            sb.Append("  GammaMu: ").Append(GammaMu).Append("\n");
            sb.Append("  HssLimitPlasticStrain: ").Append(HssLimitPlasticStrain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
