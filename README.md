# flappy-snake-csharp

Aplicatie desktop realizata in C# (Windows Forms) pentru atestat, care include autentificare utilizator si doua mini-jocuri: Flappy Pig si Snake.

## Descriere
Proiectul ofera o experienta simpla de tip arcade, cu accent pe logica jocurilor, interfata grafica si persistenta datelor intr-o baza de date Access.

## Tehnologii folosite
- C#
- .NET Framework 4.7.2
- Windows Forms
- Microsoft Access (.mdb)
- ADO.NET (OleDb)

## Functionalitati principale
- Inregistrare utilizator nou
- Logare utilizator existent
- Validare date introduse in formulare
- Salvare date utilizatori in baza de date
- Joc Flappy Pig
- Joc Snake
- Salvare scoruri pentru utilizator

## Structura proiect
- `flappy-snake-csharp.sln` - solutia Visual Studio
- `flappy-snake-csharp/` - codul sursa al aplicatiei
- `flappy-snake-csharp/bdatestat.mdb` - baza de date Access

## Cerinte
- Windows 10/11
- Visual Studio 2019 sau mai nou
- .NET Framework 4.7.2
- Motor Access Database Engine (pentru fisiere .mdb)

## Rulare proiect
1. Deschide fisierul `flappy-snake-csharp.sln` in Visual Studio.
2. Seteaza configuratia pe `Debug` sau `Release`.
3. Ruleaza aplicatia (Start / F5).

## Baza de date
Aplicatia foloseste fisierul `bdatestat.mdb` pentru stocarea conturilor si a scorurilor.
