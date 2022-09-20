using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerilogDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("Você requisitou a pagina index");

            try
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i == 56)
                    {
                        throw new Exception("Esta é a demo da exception");
                    }
                    else
                    {
                        _logger.LogInformation("O valor de i é {iVariable}", i);
                    }

                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception capturada na chamada de index");
            }
        }
    }
}
