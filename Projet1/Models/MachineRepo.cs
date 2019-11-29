using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class MachineRepo : IMachineRepo
    {
        private IDbConnection connection;

        public IEnumerable<MachineACafeEntity> All => connection.Query<MachineACafeEntity>("SELECT * FROM MachineACafe");

        public MachineRepo(IDbConnection connection)
        {
            this.connection = connection;
        }

        public MachineACafeEntity GetById(int id) =>
            connection.QueryFirst<MachineACafeEntity>("SELECT * FROM MachineACafe WHERE Id = @Id", new { Id = id });
        

        public void Save(MachineACafeEntity machinecafe)
        {
            string sql;
            if (machinecafe.Id.HasValue)
            {
                sql = "UPDATE MachineACafe SET (Nom, Marque, Image, Prix, Disponible, UserId ) VALUES (@Nom, @Marque, @Image, @Prix, @Disponible, @UserId) WHERE Id=@Id";
            }
            else
            {
                sql = "INSERT INTO MachineACafe (Nom, Marque, Image, Prix, Disponible, UserId ) VALUES (@Nom, @Marque, @Image, @Prix, @Disponible, @UserId)";

            }
            connection.Execute(sql, machinecafe);
        }
    }
}
