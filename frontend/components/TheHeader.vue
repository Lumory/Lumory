<template>
	<Container class="container">
		<nuxt-link to="/"><img class="long-logo--size logo" src="~/assets/img/Logo-horizontal.svg" alt="Lumory logo"></nuxt-link>
		<Menu class="burger-menu icon--size" @click="showMenu = !showMenu" tabindex="0" v-on:keyup.enter="showMenu = !showMenu" />
		<!-- v-if vs v-show -->
		<nav v-if="loggedIn === undefined" class="navigation">
			<nuxt-link to="/student" class="navigation__link">Studenten</nuxt-link>
			<nuxt-link to="/stagebedrijf" class="navigation__link">Stagebedrijven</nuxt-link>
			<nuxt-link to="/werkgever" class="navigation__link">Werkgevers</nuxt-link>
			<nuxt-link to="/signin" class="navigation__link">Log in</nuxt-link>
			<nuxt-link to="/signup">
				<n-button class="navigation__register-button" secondary round>Registreren</n-button>
			</nuxt-link>
		</nav>
		<nav v-if="loggedIn === 'Student'" class="navigation">
			<nuxt-link to="/matched" class="navigation__link">Gematchte stages</nuxt-link>
			<n-dropdown tabindex="0" keyboard trigger="click" :options="options" @select="handleSelect" :show-arrow="true">
				<n-button circle tertriary>
					<n-icon><Person /></n-icon>
				</n-button>
			</n-dropdown>
		</nav>

		<!-- mobile menu -->
		<div v-if="showMenu" class="mobile-menu-container">
			<div class="mobile-menu">
				<div class="mobile-menu__header">
					<div />
					<nuxt-link @click="showMenu = !showMenu" to="/"><img class="logo--size logo" src="~/assets/img/logo.svg" alt="Lumory logo"></nuxt-link>
					<Close class="close-menu icon--size" @click="showMenu = !showMenu" tabindex="0" v-on:keyup.enter="showMenu = !showMenu" />
				</div>
				<nav v-if="loggedIn === undefined" class="mobile-navigation">
					<nuxt-link @click="showMenu = !showMenu" to="/student" class="navigation__link --white">Studenten</nuxt-link>
					<nuxt-link @click="showMenu = !showMenu" to="/stagebedrijf" class="navigation__link --white">Stagebedrijven</nuxt-link>
					<nuxt-link @click="showMenu = !showMenu" to="/werkgever" class="navigation__link --white">Werkgevers</nuxt-link>
					<nuxt-link @click="showMenu = !showMenu" to="/signin" class="navigation__link --white">Log in</nuxt-link>
					<nuxt-link @click="showMenu = !showMenu" to="/signup" class="navigation__link --white">Registreren</nuxt-link>
				</nav>
				<nav v-if="loggedIn === 'Student'" class="mobile-navigation">
					<nuxt-link @click="showMenu = !showMenu" to="/matched" class="navigation__link --white">Gematchte stages</nuxt-link>
					<nuxt-link @click="showMenu = !showMenu" :to="`/u/${UUID}`" class="navigation__link --white">Mijn profiel</nuxt-link>
					<nuxt-link @click="showMenu = !showMenu; setLoggedOut()" class="navigation__link --white" to="/signin">Uitloggen</nuxt-link>
				</nav>
			</div>
		</div>
	</Container>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import { Menu, Close, Person } from '@vicons/ionicons5';
import { NButton, NDropdown, NIcon } from 'naive-ui';

export default defineComponent({
	data() {
		return {
			showMenu: false,
			loggedIn: getCookieValue('JWT').userType,
			UUID: getCookieValue('JWT').id,
		};
	},
	setup() {
		return {
			options: [
				{
					label: "Mijn profiel",
					key: "Profiel",
					keyboard: true
				},
				{
					label: "Uitloggen",
					key: "Uitloggen"
				}
			],
			handleSelect(key: string) {
				switch (key) {
					case "Uitloggen":
						setLoggedOut()
						navigateTo('/signin')
						break
					case "Profiel":
						navigateTo(`/u/${getCookieValue('JWT').id}`)
				}
				if (key === "Uitloggen") {
					setLoggedOut()
					navigateTo(`/signin`)
				} 
			}
		}
	},
	// mounted() {
	// 	console.log(getCookieValue('user'))
	// 	this.initials = getProfileInitials('user')
	// },
	components: {
		Close,
		Menu,
		NButton,
		NDropdown,
		NIcon,
		Person,
	},
});

</script>

<style scoped>
.container {
	display: flex;
	max-height: 70px;
	height: 70px;
	flex-direction: row;
	justify-content: space-between;
	align-items: center;
}
.logo:hover {
	cursor: pointer;
}
.long-logo--size {
	width: 150px;
}
.logo--size {
	height: 60px;
}
.burger-menu:hover {
	cursor: pointer;
}
.icon--size {
	width: 40px;
}
.mobile-menu-container {
	position: absolute;
	height: 100vh;
	width: 100vw;
	left: 0;
	bottom: 0;
	background-color: rgba(13, 0, 255, 0.171);
	z-index: 99;
}
.mobile-menu {
	position: fixed;
	height: 100%;
	width: 100%;
	left: 0;
	bottom: 0;
	background-color: var(--color-background-two);
}
.mobile-menu__header {
	height: 70px;
	display: flex;
	align-items: center;
	justify-content: space-between;
	margin: 10px;
	margin-left: 10%;
}
.close-menu {
	color: white;
}
.close-menu:hover {
	cursor: pointer;
}
.mobile-navigation {
	display: flex;
	flex-direction: column;
	gap: 45px;
	margin-top: 10%;
	margin-left: 10%;
}
.navigation {
	display: none;
	gap: 20px;
	align-items: center;
}
.navigation__link {
	padding: 10px;
}
.navigation__link:hover {
	cursor: pointer;
	color: rgb(128, 128, 128);
}
.navigation__register-button{
	background-color: var(--color-primary);
	color: var(--color-white);
	border: none;
}
.navigation--logged-out, .navigation--logged-in {
	gap: 20px;
}
.navigation__user-profile {
	border: black 1px solid;
	border-radius: 50%;
}
.navigation__user-profile {
	width: 30px;
	height: 30px;
	display: flex;
	align-items: center;
	justify-content: center;
	font-weight: 600;
	font-size: 0.8em;
}
.navigation__user-profile:hover {
	cursor: pointer;
}

@media screen and (min-width: 1024px) {
	.burger-menu {
		display: none;
	}
	.navigation {
		display: flex;
	}

}
</style>