' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports Microsoft.CodeAnalysis
Imports Microsoft.CodeAnalysis.Diagnostics
Imports Microsoft.CodeAnalysis.VisualBasic
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax

Namespace Roslyn.Diagnostics.Analyzers   
    ''' <summary>
    ''' RS0013: Do not invoke Diagnostic.Descriptor
    ''' </summary>
    <DiagnosticAnalyzer(LanguageNames.VisualBasic)>
    Public NotInheritable Class BasicDoNotInvokeDiagnosticDescriptorAnalyzer
        Inherits DoNotInvokeDiagnosticDescriptorAnalyzer

    End Class
End Namespace