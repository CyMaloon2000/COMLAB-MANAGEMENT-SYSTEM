using CapstoneProj.Model.dbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProj.Model
{
    public class UnitOfWork : IDisposable
    {
        private CLMSEntities context;
        public UnitOfWork() 
        {
            try
            {
                context = new CLMSEntities();

                //using (GenericContext context = new GenericContext())
                //{
                //{
                //    this.context = context;
                //}

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {

            }
        }

        private GenericRepository<Person> personRepository;

        public GenericRepository<Person> PersonRepository
        {
            get
            {
                if (this.personRepository == null)
                {
                    this.personRepository = new GenericRepository<Person>(context);
                }
                return personRepository;
            }
        }

        private GenericRepository<Student> studentRepository;

        public GenericRepository<Student> StudentRepository
        {
            get
            {
                if (this.studentRepository == null)
                {
                    this.studentRepository = new GenericRepository<Student>(context);
                }
                return studentRepository;
            }
        }
        private GenericRepository<Admin> adminRepository;
        public GenericRepository<Admin> AdminRepository
        {
            get
            {
                if (this.adminRepository == null)
                {
                    this.adminRepository = new GenericRepository<Admin>(context);
                }
                return adminRepository;
            }
        }
        private GenericRepository<Term> termRepository;
        public GenericRepository<Term> TermRepository
        {
            get
            {
                if (this.termRepository == null)
                {
                    this.termRepository = new GenericRepository<Term>(context);
                }
                return termRepository;
            }
        }

        private GenericRepository<Computer> computerRepository;
        public GenericRepository<Computer> ComputerRepository
        {
            get
            {
                if (this.computerRepository == null)
                {
                    this.computerRepository = new GenericRepository<Computer>(context);
                }
                return computerRepository;
            }
        }

        private GenericRepository<Laboratory> laboratoryRepository;
        public GenericRepository<Laboratory> LaboratoryRepository
        {
            get
            {
                if (this.laboratoryRepository == null)
                {
                    this.laboratoryRepository = new GenericRepository<Laboratory>(context);
                }
                return laboratoryRepository;
            }
        }

        private GenericRepository<Reservation> reservationRepository;
        public GenericRepository<Reservation> ReservationRepository
        {
            get
            {
                if (this.reservationRepository == null)
                {
                    this.reservationRepository = new GenericRepository<Reservation>(context);
                }
                return reservationRepository;
            }
        }

        private GenericRepository<ProgramCourse> programCourseRepository;

        public GenericRepository<ProgramCourse> ProgramCourseRepository
        {
            get
            {
                if (this.programCourseRepository == null)
                {
                    this.programCourseRepository = new GenericRepository<ProgramCourse>(context);
                }
                return programCourseRepository;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
