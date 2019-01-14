import React from "react";
import Paper from "@material-ui/core/Paper"
import Typography from "@material-ui/core/Typography"

export class Week_11_component extends React.Component {
  render() {
    return (

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Săptămâna a 11-a
          </Typography>

          <Typography component="p" align="justify">
          Ca și în săptămâna 10, s-a lucrat intens pe front-end. S-au integrat la proiect task-uri din săptămânile trecute, precum componenta de exportare sau modeul de
texturare al cuburilor. S-au reparat niste bug-uri cu privire la validarea construcției, dar și formatul json-ului și scrierea în fișier. De asemenea, s-au realizat
noi funcționalități precum exportarea modelului 3D în format json, importarea de fișiere json care descriu sculpturi lego, animația de prezentare a soluției, adaugarea
tipului algoritmului selectat în json și realizarea unei texturi pentru forma lego de 1x1. Săptămâna s-a incheiat cu finalizarea task-urilor de lucru cu privire la
gestionarea IO a datelor și validarea construcției modelului 3D.
          </Typography> 
        </Paper>

    );
  }
}
