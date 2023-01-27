type Skill = {
    title: String
    description: String
    imageURL: String
}
type StudentQuestionnaire = {
    id: Number
    userId: Number
    problem: string[]
    skillsToLearn: string[]
    strongQualities: string[]
    strongSkills: string[]
    sector: string[]
    teamwork: string[]
    mentorship: string[]
    city: string
    educationalInstitution: string
    study: string
    studyDirection: string
    studyNiveau: string
    averageGrade: Number
    internshipType: string
    dateStart: string
    hours: Number
    days: string
    createdAt: String
    updatedAt: String
}

type Internship = {
    id: string
    companyId: string
    problem: string
    problemDescription: string
    skillsIntern: string
    skillsInternDescription: string
    qualitiesIntern: string
    qualitiesInternDescription: string
    sector: string
    sectorDescription: string
    teamwork: string
    teamworkDescription: string
    mentorship: string
    mentorshipDescription: string
    money: string
    remoteWork: string
    function: string
    responsability: string
    workExperience: string
    staff: string
    website: string
    streetAddress: string
    city: string
    contactPersonFirstName: string
    contactPersonLastName: string
    contactPersonEmail: string
    international: string
    dateStart: string
    hours: number
    applyBefore: string
    createdAt: string
    updatedAt: string
}