
# Astuces

## Test driven development - base
- Toujours un test avant le code
- Rapidement au vert
- Pas de test cassé lors du refactoring
- Pas de débougeur
- Le nom des méthodes de test doivent être une documentation de la classe

---
## Refactoring
- Commencer par la droite - il y a moins de dépendances
- Rapprocher la déclaration des variables de leur utilisation
- Déplacer le code vers l’objet qui contient les données
- Extraire des méthodes et variables descriptifs
- Faire validations en premier

---
## Test legacy
- Ne pas toucher du code non testé
- Si on doit toucher pour rendre testable: Uniquement refactorings automatiques:
    - "extract method and override"
    - "extract method"
    - "introduce parameter"
- Commencer à tester par la gauche
- Utiliser la couverture de test pour vérifier qu’on teste bien la branche qu’on pensait

---

## TDD avec dépendances non testables
- Isoler les dépendances difficiles du reste de l’algorithme
- Définissez un contrat en testant ces dépendances en intégration (avec le vrai "truc") tant que possible
- Construisez des simulateurs (si possible avec du contract testing)
- Le reste de l’application peut se fier à ce contrat à l’aide des simulateurs construits
- Séparer les tests d'intégration ciblée des autres tests (autre job CI)


----






<div style="page-break-after: always;"></div>


# Raccourcis

## Jetbrains

| --- | --- | --- |
| | Win | Mac |
| **Anything** | CTRL + SH + A | CMD + SH + A |
| Run new test | CTRL + SH + F10 | CTRL + SH + R |
| Rerun test | ALT + SH + R | CTRL + R |
| Refactor this | CTRL + ALT + SH + T | CTRL + T |
| Rename | SH + F6 | SH + F6 |
| Extract method | CTRL + ALT + M | CMD + OPTION + M | Variable = V, Parameter = P, ...
| Quick fix | ALT + ENTER | ALT + ENTER |
| New (test) method | ALT + INSERT | CMD + N |


## VS Code

| --- | --- | --- |
| | Win | Mac |
| **Anything*() | CTRL + SH + P | CMD + SH + P |
| Quick fix |  CTRL + . |
| Refactor this | CTRL + SH + R |
| Rename | F2 |
| Extract method | CTRL + . |
| Run test  | Not assigned | workbench.action.tasks.test
| Go to test  | - |
| New (test) method | - |

