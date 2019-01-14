import React from "react";
import Paper from "@material-ui/core/Paper";
import Typography from "@material-ui/core/Typography";

export class HomePage extends React.Component {
  render() {
    return (
      <div className="content-papers">
        <Paper className={"content"}>
          <Typography variant = "h3" color="inherit" component="h3">
            Lego Assembly
          </Typography>
        </Paper>

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Scurtă descriere
          </Typography>
        
          <Typography component="p" align="justify">
            Proiectul “Lego assemblings” are ca scop optimizarea structurilor topologice și generarea automată de sculpturi realizate din cărămizi Lego. Acest lucru va fi realizat cu ajutorul algoritmilor genetici, codificând graful ce urmează a fi asamblat drept un cromozom. Urmărind pașii de inițializare, mutație și încrucișare, vom putea folosi o funcție de evaluare pentru a estima fitnessul structurii obținute.
          </Typography> 

          <Typography component="p" align="justify">
            Din punct de vedere structural, proiectul este compus din două aplicații desktop: una de front-end și cealaltă de back-end. Aplicația front end este un editor 3D care permite realizarea de modele 3D doar din cuburi și exportarea acestora într-un format text specific. Astfel de fișiere sunt importate apoi în aplicația back-end, unde sunt prelucrate cu scopul de obține sculpturi Lego care apoi sunt exportate în format text. Sculpturile Lego au aceeași formă și dimensiune ca și modelele 3D, doar că sunt realizate din piese Lego specifice și nu doar din cuburi. În final, aplicația front-end permite și vizualizarea unei animații de construire a sculpturilor.  
          </Typography> 
        </Paper>

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Legături utile
          </Typography>
        
          <Typography component="p" align="justify">
            <a target="_blank" href="https://github.com/Lucian-Bosinceanu/lego-assembly-front">Front-end Github repository</a> <br/><br/>
            <a target="_blank" href="https://github.com/Lucian-Bosinceanu/lego-assembly-back">Back-end Github repository</a>  <br/><br/>
            <a target="_blank" href="https://tinyurl.com/ydxjhxxg">Fișa proiectului</a> <br/><br/>
          </Typography> 

        </Paper>
      </div>
    );
  }
}
