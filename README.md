# Rookie Assignment: Ecommerce Web Project

## 1. Technologies and Frameworks used
- __Language__: C#, JavaScript, HTML, CSS,...
- __Technologies__: ASP.Net Core 5.0, Identity Server 4, Entity Framework 5.0, [React](https://en.wikipedia.org/wiki/React_(JavaScript_library))
- __Database__: Microsoft SQL Server 2019 
- __Deploy__: Microsoft Azure

## 2. Structure and Functionality
![My Shop Architecture](https://github.com/v-theemptybox/r00k1e-nashtech/blob/master/img/folder_structure.jpg)
### I. Backend (Entity Framework - Code first)
- APIs Provider and Handles
- Models
- Identity Server
- All NuGet packages: 
```cs
<ItemGroup>
    <PackageReference Include="IdentityServer4.AspNetIdentity" Version="4.1.2" />
    <PackageReference Include="Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore" Version="5.0.4" />
    <PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="5.0.4" />
    <PackageReference Include="Microsoft.AspNetCore.Identity.UI" Version="5.0.4" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="5.0.4" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="5.0.4" />
    <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="5.0.2" />
    <PackageReference Include="Swashbuckle.AspNetCore" Version="6.1.1" />
</ItemGroup>
```
### II. Client Site (Models - Views - Controllers)
- Home page: Category menu, All products, View All" button and "View More" button
- View products by category
- View product details
- Product ratings
- Login/Logout
- Regist
- All NuGet packages: 
```cs
<ItemGroup>
    <PackageReference Include="IdentityModel" Version="5.1.0" />
    <PackageReference Include="Microsoft.AspNetCore.Authentication.OpenIdConnect" Version="5.0.4" />
    <PackageReference Include="Microsoft.IdentityModel.Tokens" Version="6.10.0" />
    <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="5.0.2" />
</ItemGroup>  
```

### III. Admin Site (React - also known as React.js or ReactJS)
- Manage product categories
- Manage products
- View customers
- Build setup:
```bash
# create react app
$ npx create-react-app ecommerce-react-admin
$ cd ecommerce-react-admin
$ npm start

# add reactstrap(optional)
$ npm install --save reactstrap react react-dom
$ npm install --save bootstrap

# to call api use axios
$ npm i axios

# to use Link, Route use react-router-dom
$ npm i react-router-dom

# login/logout with cookies
$ npm i react-cookie
$ npm i prop-types
```
### IV. Unit Test (xUnit.net)
- Categories Controller
- Brands Controller

## 3. For more:
:octocat: https://github.com/v-theemptybox
