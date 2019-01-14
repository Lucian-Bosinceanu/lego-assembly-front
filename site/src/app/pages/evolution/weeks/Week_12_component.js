import React from "react";
import Paper from "@material-ui/core/Paper"
import Typography from "@material-ui/core/Typography"

export class Week_12_component extends React.Component {
  render() {
    return (

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Săptămâna a 12-a
          </Typography>

          <Typography component="p" align="justify">
          Echipa de back-end a început lucrul intens la un algoritm genetic pentru soluționarea îmbinării cuburilor din modelul 3D cu scopul de a obține sculptura lego. În plus,
s-a lucrat la integrarea modulului de obținere a output-ului în urma îmbinării. Colegii de la front-end au lucrat la integrarea funcționalităților implementate în 
săptămâna anterioară la proiect. Astfel, s-a făcut legătura dintre funcționalitatea de import a fișierelor json care modelează sculpturi lego cu butoanele de import și
modului de prezentare al soluției. De asemenea, au făcut teste cu privire la legătura modului IO cu aplicația back-end.
          </Typography> 
        </Paper>

    );
  }
}
