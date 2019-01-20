import React from "react";
import Paper from "@material-ui/core/Paper";
import Typography from "@material-ui/core/Typography";

export class ProjectPage extends React.Component {
  render() {
    return (
      <div className="content-papers">
        <Paper className={"content"}>
          <Typography variant = "h3" color="inherit" component="h3">
            Descrierea proiectului
          </Typography>
        </Paper>

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Front-end
          </Typography>
        
          <Typography component="p" align="justify">
            A fost realizat în Unity și este un editor care permite realizarea de modele 3D din cubulețe. În plus, permite vizualizarea construcției sculpturii rezultate  în
urma aplicării algoritmului de pe back-end.
          </Typography> 

          <Typography component="p" align="justify">
          Workflow general al aplicației front-end:
Lansăm aplicația. În mijloc se află un plan 3D pe care este plasat un cub. Acela este cubul origine.
Apăsăm click-stânga pe cubul origine. 5 săgeți vor ieși atunci din el, una pe fiecare latură, arătând posibilele direcții de extindere. Din meniul de sus putem schimba culoarea cubului selectat.
Ținem click-stânga apăsat pe o săgeată și tragem cursorul în direcția acesteia, clonând, astfel, cubul selectat anterior.
Modelăm restul de model 3D în această manieră.
Selectăm un cub apăsând click-stânga. Dacă apăsăm click-dreapta, acesta va fi șters.
La final, apăsăm butonul Exportă din meniul ”File...”. Dacă arhitectura modelului este deficitară (nu există drum de la cubul inițial la toate celelalte cuburi), exportul nu va funcționa și toate cuburile cu probleme vor fi marcate. Altfel, se va genera un fișier text care descrie modelul 3D.
După ce obținem un fișier cu sculptura Lego de la aplicația back-end, acesta va putea fi importat în front-end prin apăsarea butonului Import din meniul ”File...”.
Odată încarcată o sculptură Lego, editorul 3D va fi înlocuit de o interfață care permite vizualizarea algoritmului de construcție prin intermediul unei animații controlabile de un controller cu butoane specifice (menționate anterior). 
          </Typography> 

          <Typography component="p" align="justify">
            Documentația acestui modul poate fi studiată <a target="_blank" rel="noopener noreferrer" href="https://docs.google.com/document/d/1x3vDRiV3cHJxdFpaneOJhy8xnuL_6-MMlpO9ytEMIRs/edit?usp=sharing">aici</a>.
          </Typography> 
        </Paper>

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Back-end
          </Typography>
        
          <Typography component="p" align="justify">
            Componenta de backend a proiectului Lego Assembly a fost realizată în Python și este componenta unde se realizează asamblarea pieselor, optimizarea lor și verificarea integrității și resprectiv a rezistenței structurii date de utilizator. În cadrul acestei componente, am ales să folosim o abordare cât se poate de modulară. Backendul oferă utilizatorului doi algoritmi de asamblare: unul determinist (greedy), altul nedeterminist (folosind algoritmi genetici).
          </Typography>

          <Typography component="p" align="justify">
            Programul necesită ca input un model 3D partiționat în multiple straturi, fiecare fiind împărțit într-o grilă dreptunghiulară. Fiecare pătrat din această grilă ori va fi umplut cu un cub Lego, fie lăsat gol, iar anumite pătrate pot fi alipite pentru a crea cărămizi mai complexe. În urma aplicăriii algoritmului de îmbinare a cuburilor
  (fie în variantă deterministă greedy, fie nedetermist în stil genetic) rezultă o structură de date reprezentată prin intermediul unui graf. Acesta este apoi validat din
  punct de vedere structural, asigurându-ne că este conex și că fiecare nod nu prezintă vulnerabilități (adică ar putea fi eliminat din graf fără ca acesta să își piardă
  conexitatea). Dacă în urma aceste validări se obține o structură stabilă, atunci întregul algoritm de îmbinare se oprește și se prelucrează graful cu scopul de a obține
  un fișier json care descrie structura lego rezultată.
          </Typography> 

          <Typography component="p" align="justify">
            Mai multe detalii despre implementare pot fi consultate <a target="_blank" rel="noopener noreferrer" href="https://docs.google.com/document/d/1lvSpbeV6_kL1B4AEgvQXipJgMAhBDqdsoECw1Dg0nNY/edit?usp=sharing">aici</a>.
          </Typography> 
        </Paper>

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Testare
          </Typography>
        
          <Typography component="p" align="justify">
            Se va realiza, în mare parte, manual. În cadrul testării vom merge după un test plan. Vom crea scenarii de utilizare și câteva mockup-uri pe care le vom folosi în momentul în care aplicația va fi funcțională. Aceste date de intrare fie se vor realiza manual, fie utilizând aplicația front-end, fie le vom realiza în Use Cubes până când aceasta va fi gata, astfel întocmind un model pentru user de a crea o componentă. Ne vom interesa cum se crează acele forme și vom încerca să realizăm forme cât mai diferite și mai diverse pentru a avea un coverage cât mai mare de testare al aplicației. De asemenea, vom include și testare automată, și manuală pe parcursul proiectului. Se vor scrie unit teste la nivel de back-end.
          </Typography> 
        </Paper>

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Administrare
          </Typography>
        
          <Typography component="p" align="justify">
            De administrarea proiectului s-a ocupat Bosînceanu Lucian-Andrei și a presupus proiectarea modului de funcționare al aplicației, împărțirea pe module, crearea
  repertoriilor pe Github, facilitarea comunicării dintre membri prin realizarea de grupuri de chat pe Facebook si Discord, precum și pregătirea tablelor Kanban
  pe Meistertask și discuții de clarificare a sarcinilor de lucru. În plus, munca de administrare a presupus și realizarea acestui website.
          </Typography> 

          <Typography component="p" align="justify">
            Informații mai detaliate pot fi accesate de <a target="_blank" rel="noopener noreferrer" href="https://docs.google.com/document/d/1A0Ti1eXt3QSCbgCxKYxss9wlRSkxZksDR1ondyvdw0c/edit?usp=sharing">aici</a>.
          </Typography> 
        </Paper>
      </div>
    );
  }
}
