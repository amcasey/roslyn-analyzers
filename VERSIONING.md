﻿Versioning scheme for .NET Compiler Platform ("Roslyn") Analyzers
=================================================================

Following is the versioning scheme that is being used for analyzer packages:

1. The major and minor version numbers of the packages track the major and minor version numbers of Microsoft.CodeAnalysis package that the analyzer is dependent upon. For example, version 1.0.0, 1.0.1, ..., 1.0.X of the analyzer packages depend upon version 1.0.0 of Microsoft.CodeAnalysis package.

2. When we move the repo to a newer version of Microsoft.CodeAnalysis, say 1.X.0, then the version number of all the analyzer packages will be bumped to be >= 1.X.0.

**NOTE**: An exception was applied to the above versioning scheme when we moved the analyzer packages to version 1.1.0, while still depending on version 1.0.0 of Microsoft.CodeAnalysis. This was done as we had mistakenly published 1.1.0-beta1 pre-release packages for some analyzer packages on nuget.org.

Current and Released Versions of Analyzer Packages
==================================================

Current version of all analyzer packages that are built out of this repo are tracked in [Analyzers.Versions.targets](.//build//Targets//Analyzers.Versions.targets)

Released versions of analyzer packages, with the last GitHub Commit Tag and SHA are below:

Sr. No. |  Release Version | Commit Tag       | Commit SHA                                                                                            | Released Packages                                                                                               |
:------:|:----------------:|:----------------:|:-----------------------------------------------------------------------------------------------------:|:---------------------------------------------------------------------------------------------------------------:|
1.      |  1.1.0           | v1.1.0    | [d96fbd4](https://github.com/dotnet/roslyn-analyzers/commit/d96fbd4e4b6c1fc5b01e3dc5af80d2b15034cc8c)   | MicrosoftCodeAnalysisAnalyzers, FxCopAnalyzers, DesktopAnalyzers, SystemRuntimeAnalyzers, SystemRuntimeInteropServicesAnalyzers, SystemSecurityCryptographyHashingAlgorithmsAnalyzers, AnalyzerPowerPack
