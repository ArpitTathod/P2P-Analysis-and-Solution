using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using P2Psample1.Models;
using System.Linq;
using System.Threading.Tasks;

public class ContactFormModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public ContactFormModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public ContactForm ContactForm { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return Page();
        }

        ContactForm = await _context.ContactForms.FindAsync(id);

        if (ContactForm == null)
        {
            return NotFound();
        }

        return Page();
    }

    public async Task<IActionResult> OnPostCreateAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.ContactForms.Add(ContactForm);
        await _context.SaveChangesAsync();

        return RedirectToPage("/ContactForm");
    }

    public async Task<IActionResult> OnPostUpdateAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        try
        {
            _context.ContactForms.Update(ContactForm);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ContactFormExists(ContactForm.Id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("/ContactForm");
    }

    public async Task<IActionResult> OnPostDeleteAsync(int id)
    {
        var contactForm = await _context.ContactForms.FindAsync(id);

        if (contactForm == null)
        {
            return NotFound();


        }

        _context.ContactForms.Remove(contactForm);
        await _context.SaveChangesAsync();

        return RedirectToPage("/ContactForm");
    }

    private bool ContactFormExists(int id)
    {
        return _context.ContactForms.Any(e => e.Id == id);
    }
}
