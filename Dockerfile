#Build Stage
FROM microsoft/aspnetcore-build:2 AS build-env

WORKDIR /workdir

COPY Joker/Joker.csproj ./Joker/
RUN dotnet restore Joker/Joker.csproj

COPY Test/Test.csproj ./Test/
RUN dotnet restore Test/Test.csproj

COPY . .

ENV TEAMCITY_PROJECT_NAME=Joker
RUN dotnet test Test/Test.csproj
RUN dotnet publish Joker/Joker.csproj -o /publish

# Runtime Stage
FROM microsoft/aspnetcore:2
COPY --from=build-env /publish /publish
WORKDIR /publish
ENTRYPOINT [ "dotnet", "Joker.dll" ]