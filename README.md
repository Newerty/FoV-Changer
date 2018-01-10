
Life is Feudal MMO  FoV Changer 0.2

----SPOSÓB NA JEDNORAZOWE URUCHOMIENIE----
1. Skopiować folder ‘fov’ do folderu z grą (‘Life is Feudal MMO\game\eu\mod’)
2. Uruchomić grę normalnie.
3. W grze uruchomić konsolę (CTRL+~).
4. W konsoli wpisać polecenie ‘exec („mod/fov/fov.cs”)’
5. Nacisnąć ENTER.
6. Na czacie systemowym powinna pojawić się informacja o poprawnym uruchomieniu skryptu.
------------------------------------------


----SPOSÓB NA KAŻDORAZOWE URUCHAMIANIA SKRYPTU Z GRĄ----
1. Skopiować folder ‘fov’ do folderu z grą (‘Life is Feudal MMO\game\eu\mod’)
2. Odnaleźć plik init.cs w folderze 'Life is Feudal MMO\game\eu\scripts\client'
3. W pliku init.cs odnaleźć 'onInitClientDone();' (okolice  193 linii).
4. Przed 'onInitClientDone();' dopisać 'exec("mod/fov/fov.cs");'
5. Zapisać plik 'init.cs'
6. Uruchomić grę normalnie. 
------------------------------------------


Czynności należy powtórzy po każdym uruchomieniu gry.

Od teraz przewijając kółkiem myszy możemy ustalać widok w grze, a po wciśnięciu kółka myszki włączy/wyłączy się zoom celowniczy. 
