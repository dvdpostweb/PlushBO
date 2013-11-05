using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Tamir.SharpSsh ;


namespace SSH
{
    public class SSHMain
    {
        public bool execBackupAboProcess() 
        {
            try
            {
                          
            string pwd = "b4ckup1";
            SshStream ssh = new SshStream("192.168.100.204", "backupuser", pwd);
            Thread.Sleep(1500);
            ssh.RemoveTerminalEmulationCharacters = true;
            ssh.Write("cd /data/aboprocess_data/");
            ssh.Flush();
            ssh.Write("/data/scripts/backup_aboprocess.sh \n");
            //Thread.Sleep(150);
            //ssh.Write(pwd);
            ssh.Flush();
            Thread.Sleep(45000);
            ssh.Close();
                return true;
        }
        catch (Exception)
        {

            return false;
        }
        
        }
    }
}
