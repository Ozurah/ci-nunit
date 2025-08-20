# ci-nunit
Pour tester le CI avec NUnit

https://learn.microsoft.com/en-us/dotnet/devops/dotnet-test-github-action

# Timeline

## Création de l'action

Via le template .Net de github `.NET`
![](<template CI dotNet.png>)

`.github/workflows/dotnet`

Pour le setup, changement de la version à `dotnet-version: 9.0` (au lieu de `8.0.x`)


## Génération d'un résumé des tests à publier

Reprise de ce que j'avais pour les tests avec unity : 

```yml
    # Output
    - name: Tests result 🪄
      uses: actions/upload-artifact@v4
      with:
        name: Tests result
        path: artifacts
```

et adaption de la ligne pour l'exécution des tests :

`run: dotnet test --no-build --verbosity normal --configuration Release --logger "trx;LogFileName=test_results.trx" --results-directory artifacts`

=> Les artifacts sont bien téléchargeable, et ouvrable sur VS22, mais pas d'info sur Github directement

### Recherche d'un moyen d'exporter les résultats sur Github

Liste des actions : 
- https://github.com/marketplace?query=nunit&type=actions
- https://github.com/marketplace/actions/test-reporter
  - (la plus populaire) (`dorny/test-reporter`)

Elle ne publie qu'une jolie page sur Github, pas d'upload des artefacts, donc il faut les 2 étapes :)