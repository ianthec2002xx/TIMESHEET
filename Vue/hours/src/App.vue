<template>
  <div id="app">
    <header>
      <!-- <b-button v-b-toggle.sidebar-no-header> Sidebar</b-button>
    <b-sidebar id="sidebar-no-header" aria-labelledby="sidebar-no-header-title" no-header shadow>
      <template #default="{ hide }">
        <div class="p-3">
          <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>
        <b-navbar-brand to="/">eTimesheet</b-navbar-brand>
        <b-collapse is-nav id="nav-collapse">
            <b-nav-item to="/add-project">Projects</b-nav-item>
            <b-nav-item to="team">Teams</b-nav-item>
            <b-nav-item to="hours">Hours</b-nav-item>
        </b-collapse>
          <b-button variant="primary" block @click="hide">Close Sidebar</b-button>
        </div>
      </template>
    </b-sidebar> -->
      <!-- <b-navbar vertical-variation>
        <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>
        <b-navbar-brand to="/">eTimesheet</b-navbar-brand>
        <b-collapse is-nav id="nav-collapse">
          <b-navbar-nav>
            <b-nav-item to="/add-project">Projects</b-nav-item>
            <b-nav-item to="team">Teams</b-nav-item>
            <b-nav-item to="hours">Hours</b-nav-item>
          </b-navbar-nav>
        </b-collapse>
      </b-navbar> -->
    </header>
    <main>
      <div>
        <div id="mySidenav" class="sidenav">
          <a href="#/" id="about"><b-icon icon="house" align="left"></b-icon>eTimesheet</a>
          <br>
          <a href="#/add-project" id="blog"><b-icon icon="folder-plus" align="left"></b-icon>Projects</a>
          <br>
          <a href="#/project-teams" id="projects"><b-icon icon="diagram-3" align="left"></b-icon>Teams</a>
          <br>
          <a href="#/task" id="contact"><b-icon icon="clipboard" align="left"></b-icon>Tasks</a>
        </div>
        </div>
      <router-view></router-view>
    </main> 
  </div>
</template>

<script>

  export default {
    data () {
      return {
      }
 
    }
  }
</script>

<style>
h1{
  text-align: center;
  margin-top: 40px;
}

body {
  margin: 0;
}

#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #28C69F; ;
}

main {
  text-align: center;
  margin-top: 40px;
}

header {
  margin: 0;
  height: 56px;
  padding: 0 16px 0 24px;
  background-color: #28C69F; ;
  color: #28C69F; ;
}

header span {
  display: block;
  position: relative;
  font-size: 20px;
  line-height: 1;
  letter-spacing: .02em;
  font-weight: 400;
  box-sizing: border-box;
  padding-top: 16px;
  background-color: #28C69F; ;
}

/* Style the links inside the sidenav */
#mySidenav a {
  position: absolute; /* Position them relative to the browser window */
  left: -155px; /* Position them outside of the screen */
  transition: 0.3s; /* Add transition on hover */
  padding: 15px; /* 15px padding */
  width: 180px; /* Set a specific width */
  text-decoration: none; /* Remove underline */
  font-size: 20px; /* Increase font size */
  color: white; /* White text color */
  border-radius: 0 5px 5px 0; /* Rounded corners on the top right and bottom right side */
}

#mySidenav a:hover {
  left: 0; /* On mouse-over, make the elements appear as they should */
}

/* The about link: 20px from the top with a green background */
#about {
  top: 60px;
  background-color: #28C69F;
}

#blog {
  margin-top: 8px;
  top: 120px;
  background-color: #28C69F; /* Blue */
}

#projects {
  margin-top: 16px;
  top: 180px;
  background-color: #28C69F; /* Red */
}

#contact {
  margin-top: 24px;
  top: 240px;
  background-color: #28C69F /* Light Black */
}

</style>