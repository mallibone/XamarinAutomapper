using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinDtoApp.Models;

namespace XamarinDtoApp.Services
{
	public class NoteService
	{
		public async Task<IEnumerable<Note>> GetNotes()
		{
			// Let's fake a webservice here...
			await Task.Delay(TimeSpan.FromMilliseconds(750));
			return JsonConvert.DeserializeObject<IEnumerable<Note>>(NotesJson);
		}

		private const string NotesJson = @"[
	{
		'Title': 'In Corp.',
		'Content': 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et arcu imperdiet ullamcorper. Duis at',
		'CreationDate': '2020-04-21T06:11:12-07:00',
		'LastEditDate': '2019-08-05T19:42:12-07:00'
	},
	{
		'Title': 'Enim Sed Corporation',
		'Content': 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et arcu imperdiet ullamcorper. Duis at lacus. Quisque purus sapien,',
		'CreationDate': '2020-05-05T15:40:25-07:00',
		'LastEditDate': '2020-12-14T09:04:05-08:00'
	},
	{
		'Title': 'Metus Aliquam LLC',
		'Content': 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et arcu imperdiet ullamcorper. Duis at lacus. Quisque purus sapien, gravida non, sollicitudin a, malesuada id, erat. Etiam',
		'CreationDate': '2020-09-07T14:18:06-07:00',
		'LastEditDate': '2020-03-08T20:44:34-07:00'
	},
	{
		'Title': 'Donec Tempus Inc.',
		'Content': 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et arcu imperdiet ullamcorper.',
		'CreationDate': '2020-06-20T03:09:54-07:00',
		'LastEditDate': '2020-12-16T18:54:03-08:00'
	}
]";
	}
}