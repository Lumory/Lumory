<template>
	<Container>
		<div class="page-grid">
			<div class="banner">
				<div class="banner__landscape">
					<img src="@/assets/img/Test.jpg" alt="Banner landscape image" class="banner__landscape-image">
				</div>
				<div class="banner__content--positioning">
					<div class="banner__profile-picture">
						<img src="@/assets/img/test2.jpg" alt="Profile picture" class="banner__profile-picture-image">
					</div>
					<div class="banner__content-wrapper">
						<div class="banner__content">
							<h3 class="banner__content-name">Niels Berning</h3>
							<h4 class="banner__content-subtitle">Open-ICT, Hogeschool Utrecht</h4>
						</div>
						<n-dropdown trigger="click" :options="options" @select="handleSelect">
							<ellipsis-vertical class="banner__options-icon"/>
						</n-dropdown>
					</div>
				</div>
			</div>
			<StudentProfileField class="page-grid__col-span-2" title="Opleiding">
				<n-grid cols="1 m:2" responsive="screen" x-gap="10px" y-gap="20px" class="education">
					<n-gi class="education-field">
						<school-outline class="icon--size icon--padding icon--color" />
						<div class="education-field__content-wrapper">
							<p class="education-field__title">Naam opleiding</p>
							<p class="education-field__subtitle">HBO Open-ICT</p>
						</div>
					</n-gi>
					<n-gi class="education-field">
						<school-outline class="icon--size icon--padding icon--color" />
						<div class="education-field__content-wrapper">
							<p class="education-field__title">Leerjaar</p>
							<p class="education-field__subtitle">Leerjaar 3</p>
						</div>
					</n-gi>
					<n-gi class="education-field">
						<account-balance-outlined class="icon--size icon--padding icon--color" />
						<div class="education-field__content-wrapper">
							<p class="education-field__title">Onderwijsinstantie</p>
							<p class="education-field__subtitle">Hogeschool Utrecht</p>
						</div>
					</n-gi>
					<n-gi class="education-field">
						<document-text-outline class="icon--size icon--padding icon--color" />
						<div class="education-field__content-wrapper">
							<p class="education-field__title">Propedeuse behaald</p>
							<p class="education-field__subtitle">Ja</p>
						</div>
					</n-gi>
				</n-grid>
			</StudentProfileField>
			
			<StudentProfileField title="Externe links">
					<li class="external-links__list-item">
						<logo-linkedin class="icon--padding icon--size" color="#0072b1" />
						<a href=""><u>Linkedin</u></a>
					</li>
			</StudentProfileField>

			<StudentProfileField class="page-grid__cv" title="CV">
				<div class="cv-container">
					<div class="cv-wrapper">
						<document-outline class="icon--size icon--padding" />
						<p>CV_niels_berning</p>
					</div>
					<download-filled class="icon--size download-icon" />
				</div>

			</StudentProfileField>

			<StudentProfilePreferenceField class="page-grid__col-span-2 page-grid__preference-field" title="Stagevoorkeuren" />
			<StudentProfilePreferenceField class="page-grid__col-span-2" title="Stagebedrijf voorkeuren" />
			<StudentProfilePreferenceField class="page-grid__col-span-2" title="Persoonlijkheid" />

			<StudentProfileField class="page-grid__skills" title="Vaardigheden">
				<div class="skills">
					<n-tag class="skills__tag" :bordered="false">Business</n-tag>
					<n-tag class="skills__tag" :bordered="false">Product owner</n-tag>
					<n-tag class="skills__tag" :bordered="false">Organiseren</n-tag>
					<n-tag class="skills__tag" :bordered="false">Interviewen</n-tag>
					<n-tag class="skills__tag" :bordered="false">User story mapping</n-tag>
				</div>
			</StudentProfileField>
		</div>
	</Container>
</template>

<script lang="ts">
import { EllipsisVertical, LogoLinkedin, DocumentOutline, SchoolOutline, DocumentTextOutline } from "@vicons/ionicons5";
import { DownloadFilled, AccountBalanceOutlined } from "@vicons/material";
import { useMessage, NDropdown, NGrid, NGi, NTag } from "naive-ui";

export default {
	components: {
		NDropdown,
		NGrid,
		NGi,
		EllipsisVertical,
		LogoLinkedin,
		DocumentOutline,
		DownloadFilled,
		SchoolOutline,
		DocumentTextOutline,
		AccountBalanceOutlined, 
		NTag
	},
	props: {
		title: String,
	},
	setup() {
		const message = useMessage();
		return {
			options: [
				{
					label: 'edit',
					key: 'edit',
				}
			],
			handleSelect(key: string | number) {
				message.info(String(key))
			}
		}
	}
}
</script>

<style scoped>
.page-grid {
	width: 100%;
	display: grid;
	gap: 20px;
}
.banner {
	width: 100%;
	background-color: var(--color-white);
	border-radius: 0 0 3px 3px;
	-webkit-box-shadow: 0px 2px 2px 0px rgba(0,0,0,0.05); 
	box-shadow: 0px 2px 2px 0px rgba(0,0,0,0.05);
}
.banner__landscape {
	overflow: hidden;
}
.banner__landscape-image {
	width: 100%;
	max-height: 168px;
	object-fit: cover;
	object-position: 50% 50%;
}
.banner__content--positioning {
	display: flex;
	justify-content: space-between;
	min-height: 100px;
}
.banner__profile-picture {
	min-width: 100px;
	width: 100px;
	height: 100px;
	overflow: hidden;
	border-radius: 50%;
	z-index: 1;
	margin-top: -30px;
	margin-left: 10px;
	border: solid 2px var(--color-white);
}
.banner__profile-picture-image {
	object-fit: cover;
	object-position: center;
	max-width: 150px;
	max-height: 150px;
}
.banner__content {
	margin-left: 15px;
}
.banner__content-name {
	padding-bottom: 5px;
}
.banner__content-subtitle {
	font-weight: 500;
}
.banner__content-wrapper, .external-links__list-item, .cv-container, .cv-wrapper, .education-field {
	display: flex;
}
.banner__content-wrapper {
	justify-content: space-between; 
	width: 85%;
}
.banner__options-icon {
	height: 20px;
	padding-top: 10px;
	margin-right: 25px;
}
.external-links__list-item, .cv-wrapper {
	align-items: center;
	flex-direction: row;
}
.cv__icon, .icon--padding {
	padding-right: 20px;
}
.icon--size {
	width: 20px;
}
.cv-container {
	justify-content: space-between;
}
.download-icon:hover, .banner__options-icon:hover {
	cursor: pointer;
}
.education-field__title {
	font-weight: bold;
}
.education-field__subtitle, .icon--color {
	color: var(--color-subtitle);
}

.skills__tag {
	margin: 5px;
}

@media (min-width: 640px) {
	.page-grid {
		grid-template-columns: 
		repeat(3, 1fr);
	}
	.page-grid__col-span-2 {
		grid-column: span 2;
	}
	.page-grid__cv {
		grid-column-start: 3;
	}
	.page-grid__preference-field {
		grid-row-start: 3;
	}
	.page-grid__skills {
		grid-column-start: 1;
	}
	.banner {
		grid-column: span 3;
	}
	.page-grid__skills {
		grid-column: span 2;
	}
	.banner__profile-picture {
		min-width: 150px;
		width: 150px;
		height: 150px;
		margin-left: 60px;
		margin-top: -45px;
	}
	.banner__profile-picture-image {
		max-height: none;
	}
	.banner__content {
		margin-left: 25px;
	}
	.banner__content--positioning {
		min-height: 130px;
	}
}
</style>