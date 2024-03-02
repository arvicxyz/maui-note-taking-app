using MauiNoteTakingApp.Src.Features.Home.Models;

namespace MauiNoteTakingApp.Src.Features.Home.Services
{
    public class NoteService : INoteService
    {
        public Task<List<NoteModel>> GetNotes()
        {
            var list = new List<NoteModel>
            {
                new("1","Design user interface","Create wireframes and mockups for the mobile app UI"),
                new("2","Implement authentication system","Develop a secure authentication system for user login"),
                new("3","Write unit tests for API endpoints","Create comprehensive unit tests to ensure API reliability"),
                new("4","Optimize database queries","Fine-tune database queries to improve performance"),
                new("5","Conduct security audit","Thoroughly review codebase for security vulnerabilities"),
                new("6","Prepare release notes","Document changes and improvements for version 1.2 release"),
                new("7","Refactor legacy codebase","Identify and refactor outdated code for better maintainability"),
                new("8","Implement push notification feature","Integrate push notification functionality for real-time updates"),
                new("9","Conduct user acceptance testing (UAT)","Engage stakeholders to validate system functionality and usability"),
                new("10","Design database schema for new feature","Create database schema to support upcoming feature requirements"),
                new("11","Optimize front-end performance","Reduce load times and improve responsiveness of UI elements"),
                new("12","Implement multi-language support","Enable localization for international users"),
                new("13","Review and address accessibility concerns","Ensure app meets accessibility standards for users with disabilities"),
                new("14","Integrate third-party analytics tool","Integrate analytics tool to gather insights on user behavior"),
                new("15","Perform code review for recent changes","Conduct thorough review of recent code changes for quality assurance"),
                new("16","Document API endpoints","Create API documentation for developers and third-party integrations"),
                new("17","Deploy staging environment","Set up staging environment for testing upcoming features and fixes"),
                new("18","Monitor server performance","Monitor server metrics to ensure optimal performance and uptime"),
                new("19","Implement error logging and monitoring","Set up logging and monitoring system to track application errors"),
                new("20","Design and implement admin dashboard","Create dashboard for administrators to manage system settings and data"),
                new("21","Conduct load testing","Simulate high traffic scenarios to assess system performance under load"),
                new("22","Optimize mobile app for different screen sizes","Ensure app layout and design adapt to various screen resolutions"),
                new("23","Implement file upload functionality","Allow users to upload files and attachments within the app"),
                new("24","Review and update documentation","Update existing documentation to reflect recent changes and improvements"),
                new("25","Perform security penetration testing","Engage external security experts to identify and address vulnerabilities"),
                new("26","Set up continuous integration/continuous deployment (CI/CD) pipeline","Automate build and deployment processes for faster releases"),
                new("27","Create automated regression test suite","Develop automated tests to validate application functionality across releases"),
            };
            return Task.FromResult(list);
        }

        public async Task<NoteModel> GetNote(string id)
        {
            var notes = await GetNotes();
            return notes.Single(e => e.Id.Equals(id));
        }
    }
}
