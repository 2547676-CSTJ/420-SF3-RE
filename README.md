# 420-SF3-RE

Dépôt du cours **420-SF3** (CSTJ). Contient une solution Visual Studio 2022 avec deux projets.

## Prérequis

- **Visual Studio 2022** (v17.x)
- **.NET 8 SDK** (charge de travail « Développement .NET Desktop »)
- **Windows** (le projet WPF cible `net8.0-windows` et ne compile pas sur macOS/Linux)

## Ouvrir le projet

1. Ouvrir `WpfApp1.sln` dans Visual Studio 2022.
2. Choisir le projet de démarrage selon ce que tu veux lancer (clic droit sur le projet → *Définir comme projet de démarrage*).
3. `F5` pour lancer, ou `Ctrl+Maj+B` pour compiler.

## Structure

```
420-SF3-RE/
├── WpfApp1.sln         Solution (2 projets)
├── WpfApp1/            Application WPF (net8.0-windows)
│   ├── App.xaml(.cs)
│   ├── MainWindow.xaml(.cs)
│   └── WpfApp1.csproj
└── Cours1/             Application console (net8.0)
    ├── Program.cs
    └── Cours1.csproj
```

## Projets

### WpfApp1 — application WPF
Fenêtre avec trois boutons (`Action1/2/3`) branchés à leurs gestionnaires dans le code-behind
(`MainWindow.xaml.cs`). Compile et se lance normalement.

### Cours1 — exercice de refactoring
Application console (namespace `RefactorPractice`). **Ce projet ne compile pas volontairement** :
c'est un exercice de refactoring à compléter. Dans `Program.cs` :

- la classe `Shape` déclare des méthodes `abstract` mais n'est pas marquée `abstract` (CS0513);
- `ShapeCalculator` et `Main` utilisent des membres `Type`, `Width`, `Height`, `Radius` qui
  n'existent pas sur `Shape` (CS1061 / CS0117).

L'objectif de l'exercice est de refactorer ce code (p. ex. rendre `Shape` abstraite et déplacer
le calcul d'aire/périmètre dans des sous-classes `Rectangle`, `Circle`, `Triangle`).

> Comme `Cours1` ne compile pas, **compiler la solution au complet échoue**. Pour travailler
> uniquement sur le WPF : définir `WpfApp1` comme projet de démarrage et compiler seulement ce
> projet (clic droit sur `WpfApp1` → *Générer*), ou décharger `Cours1` (clic droit → *Décharger le projet*).
