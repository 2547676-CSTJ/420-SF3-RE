# 420-SF3-RE

Dépôt du cours **420-SF3** (CSTJ). Contient une solution Visual Studio 2022 avec deux projets WPF.

## Prérequis

- **Visual Studio 2022** (v17.x)
- **.NET 8 SDK** (charge de travail « Développement .NET Desktop »)
- **Windows** (les projets ciblent `net8.0-windows` et ne compilent pas sur macOS/Linux)

## Ouvrir le projet

1. Ouvrir `WpfApp1.sln` dans Visual Studio 2022.
2. Choisir le projet de démarrage (clic droit sur le projet → *Définir comme projet de démarrage*).
3. `F5` pour lancer, ou `Ctrl+Maj+B` pour compiler la solution.

## Structure

```
420-SF3-RE/
├── WpfApp1.sln         Solution (2 projets)
├── WpfApp1/            Application WPF (net8.0-windows)
│   ├── App.xaml(.cs)
│   ├── MainWindow.xaml(.cs)
│   └── WpfApp1.csproj
└── Cours2/             Application WPF (net8.0-windows)
    ├── App.xaml(.cs)
    ├── MainWindow.xaml(.cs)
    └── Cours2.csproj
```

## Projets

### WpfApp1
Fenêtre avec trois boutons (`Action1/2/3`) branchés à leurs gestionnaires dans le code-behind
(`MainWindow.xaml.cs`).

### Cours2
Application WPF de base (fenêtre vide `MainWindow`), point de départ pour le cours.
