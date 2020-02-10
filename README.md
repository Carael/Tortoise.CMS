# Turtle.CMS

Turtle.CMS is an headless GraphQL CMS backoffice. Backoffice will use Blazor for frontend and HotChocolate GraphQL server for backend.

The goal is to support out of the box migrations of Content/DataTypes/DocumentTypes.

First step is to create a working POC that will include:
- Predefined DataTypes
  - Text
  - True/False
  - Number
  - ContentPicker
- Mutation for creating/updating DocumentTypes with child parent structure
  - Create DocumentType
  - Update DocumentType
- Mutation for adding/updating content based on the content type
- Query for retrieving the created content
- Transformation engine for generating the GraphQL endpoints

The goal is to be able to query the structure 

Create a migration that will create the Structure based on the Star Wars example (it's a trivial one but ).

# Roadmap
- [ ] POC
- [ ] Implement basic DataTypes
- [ ] Implement DocumentType initial structure
- [ ] Implement GraphQL transformation
