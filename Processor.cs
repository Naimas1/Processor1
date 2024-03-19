using System.Diagnostics;

namespace Processor1
{
    internal class Processor
    {
        static void Main()
        {
            // Путь к исполняемому файлу дочернего процесса
            string childProcessPath = "childProcess.exe";

            // Создание процесса для запуска дочернего процесса
            Process process = new Process();

            try
            {
                // Настройка запускаемого процесса
                process.StartInfo.FileName = childProcessPath;

                // Запуск дочернего процесса
                process.Start();

                // Ожидание завершения дочернего процесса
                process.WaitForExit();

                // Получение кода завершения дочернего процесса
                int exitCode = process.ExitCode;

                // Вывод кода завершения
                Console.WriteLine($"Код завершения дочернего процесса: {exitCode}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при запуске дочернего процесса: {ex.Message}");
            }
            finally
            {
                // Освобождение ресурсов процесса
                process.Dispose();
            }
        }
    }
}
