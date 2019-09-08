# FireflyTest

Tests implemented as per the Readme file that was provided.

Implemented a Page Object Model.
Implemented with Spec Flow.
Implemented with NUnit.
Tests are run in Chrome.

Improvement points:
1) Dockerise the tests and run with Selenium Grid
  - Reduces time taken to run all tests.
  - Allows cross browser testing of the same specs in parallel.
  - Can be run in the cloud (EKS instance on AWS ideal for this).
2) File Structure:
  - Feature Files ideally should be in a different project to the test code.
  - Page Objects can be put into an Object Bucket for their reference, e.g. A class used by all Step Definitions with all references to pages:
      public class Pages {
        public DashboardPage dashboardPage { get; set; };
        public EditTaskPage editTaskPage { get; set; {;
        ...
      }
    - These can then be ferenced in spec files as: pages.dashboardPage.method();
