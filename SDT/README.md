# Vs2013 Solution#
# .Net Framework 4.5#


## Db Connection String: ##
Change connection string at Web project. Web.config

    <connectionStrings>
    <add name="DbSdt" connectionString="Data Source=(local);Initial Catalog=SDT;Integrated Security=True" providerName="System.Data.SqlClient" />
    </connectionStrings>