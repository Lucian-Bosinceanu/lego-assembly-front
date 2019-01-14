import React from "react";
import Paper from "@material-ui/core/Paper"
import Typography from "@material-ui/core/Typography"
import { CardContent, CardMedia } from "@material-ui/core";
import groupImage from '../../media/grupa_B1.jpg'

export class AboutUsPage extends React.Component {
  render() {
    return (
      <div className="content-papers">
        <Paper className={"content"}>
          <Typography variant = "h3" color="inherit" component="h3">
            Despre noi - grupa B1 FII
          </Typography>
        </Paper>

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Scurtă descriere
          </Typography>

          <Typography component="p" align="justify">
            Frumoși, talentați și cu programul mereu încărcat, ne place să muncim și să ne trăim viața din plin! Iubim să facem glumițe și să râdem. Avem o singură fată în grupă -
Monica - cu care ne mândrim și de care avem grijă! <br/><br/>
            Puteți intra în contact cu noi accesând grupul nostru de <a rel="noopener noreferrer" target="_blank" href="https://www.facebook.com/groups/178670812574248/">Facebook</a> sau prin intermediul administratorului acestui proiect la adresa <b>lucian.a.bosinceanu@gmail.com</b>.
          </Typography> 
        </Paper>

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Poză de grup
          </Typography>
        
          <CardContent>
            <CardMedia
              image={groupImage}
              title="grupa B1"
              id={"group-image"}
            />
          </CardContent>
        </Paper>
      </div>
    );
  }
}
