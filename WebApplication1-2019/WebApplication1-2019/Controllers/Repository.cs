using WebApplication1_2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Nest;

namespace WebApplication1_2019.Controllers
{
	public interface IMasiniRepository
	{
		void CreateMasini(Masini reservation);
		List<Masini> GetAllMasinis();
		Masini GetMasiniById(Guid id);
		void DeleteMasini(Masini reservation);
	}

	public class MasiniRepository : IMasiniRepository
	{
		private readonly List<Masini> List;

		public MasiniRepository()
		{
			List = new List<Masini>();
			List.Add(new Masini
			{
				Id = Guid.NewGuid(),
				Zona = "Circumvalatiunii nr.27",
				Model_masina= "Mercedes-Benz C220"
			});
			List.Add(new Masini
			{
				Id = Guid.NewGuid(),
				Zona = "Circumvalatiunii nr.27",
				Model_masina = "Mercedes-Benz C220"
			});
			List.Add(new Masini
			{
				Id = Guid.NewGuid(),
				Zona = "Torontalului nr.27",
				Model_masina = "Audi A4"
			});
			List.Add(new Masini
			{
				Id = Guid.NewGuid(),
				Zona = "Torontalului nr.27",
				Model_masina = "Volvo S90"
			});
			List.Add(new Masini
			{
				Id = Guid.NewGuid(),
				Zona = "Gh. Lazar nr.36",
				Model_masina = "BMW 320"
			});
			List.Add(new Masini
			{
				Id = Guid.NewGuid(),
				Zona = "Gh. Lazar nr.36",
				Model_masina = "BMW 720"
			});
			List.Add(new Masini
			{
				Id = Guid.NewGuid(),
				Zona = "Calea Sagului, Shopping City",
				Model_masina = "Opel Insignia"
			});
			List.Add(new Masini
			{
				Id = Guid.NewGuid(),
				Zona = "Lugojului nr.8",
				Model_masina = "Volkswagen Tiguan"
			});
		}
		public void CreateMasini(Masini reservation)
		{
			List.Add(reservation);
		}

		public void DeleteMasini(Masini reservation)
		{
			List.Remove(reservation);
		}

		public List<Masini> GetAllMasinis()
		{
			return List;
		}

		public Masini GetMasiniById(Guid id)
		{
			return List.FirstOrDefault(_ => _.Id == id);
		}

		void IMasiniRepository.CreateMasini(Masini reservation)
		{
			throw new NotImplementedException();
		}

		void IMasiniRepository.DeleteMasini(Masini reservation)
		{
			throw new NotImplementedException();
		}

		List<Masini> IMasiniRepository.GetAllMasinis()
		{
			throw new NotImplementedException();
		}

		Masini IMasiniRepository.GetMasiniById(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}