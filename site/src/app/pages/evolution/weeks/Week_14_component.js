import React from "react";
import Paper from "@material-ui/core/Paper"
import Typography from "@material-ui/core/Typography"

export class Week_14_component extends React.Component {
  render() {
    return (

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Săptămâna a 14-a
          </Typography>

          <Typography component="p" align="justify">
            S-au finalizat sarcinile de lucru atât pe partea de front, cât și pe back. Colegii de la testare au început să teste aplicația din prisma corectidunii,
  performanței și a complexității. S-a inceput lucrul la documentația proiectului. Pe partea de administrare s-a finalizat lucrul la acest site: adăugarea 
  întregului conținut necesar și lansarea pe Github. Ne pregătim pentru prezentarea proiectului!  
          </Typography> 
        </Paper>

    );
  }
}
