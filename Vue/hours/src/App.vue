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
      <b-navbar vertical-variation>
        <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>
        <b-navbar-brand to="/">eTimesheet</b-navbar-brand>
        <b-collapse is-nav id="nav-collapse">
          <b-navbar-nav>
            <b-nav-item to="/add-project">Projects</b-nav-item>
            <b-nav-item to="team">Teams</b-nav-item>
            <b-nav-item to="hours">Hours</b-nav-item>
          </b-navbar-nav>
        </b-collapse>
      </b-navbar>
    </header>
    <main>
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

</style>