using System;
using System.Collections.Generic;
using System.Linq;
using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
              var articles = new List<Article>();

              articles.Add(new Article("Artigo 1", "URL A 1"));
              articles.Add(new Article("Artigo 2", "URL A 2"));
              articles.Add(new Article("Artigo 3", "URL A 3"));
              articles.Add(new Article("Artigo 4", "URL A 4"));
              articles.Add(new Article("Artigo 5", "URL A 5"));              

              foreach(var article in articles){
                  
                  Console.WriteLine($"Id: {article.Id}");
                  Console.WriteLine($"Nome: {article.Title}");
                  Console.WriteLine($"Url: {article.Url}");
              }

              var courses = new List<Course>();

              var course_1 = new Course("Course 1", "URL C 1");
              var course_2 = new Course("Course 2", "URL C 2");
              var course_3 = new Course("Course 3", "URL C 3");
              var course_4 = new Course("Course 4", "URL C 4");
              var course_5 = new Course("Course 5", "URL C 5");

              courses.Add(course_1);
              courses.Add(course_2);
              courses.Add(course_3);
              courses.Add(course_4);
              courses.Add(course_5);

              var careers = new List<Career>();
              var careerDotNet = new Career("Especialista .NET", "url espcialista");
              var careerItem = new CareerItem(1,"Comece por aqui", "", course_1);

              careerDotNet.Items.Add(careerItem);
              careers.Add(careerDotNet);

              foreach(var career in careers){
                  Console.WriteLine(career.Title);

                  foreach(var item in career.Items.OrderBy(x => x.Order)){
                      //usamos essa função orderBy para deixar os itens em ordem crescente.
                      Console.WriteLine(($"{item.Order} - {item.Title}"));
                      Console.WriteLine(item.Course.Title);
                      Console.WriteLine(item.Course.Level);
                  }        
              }

                          

               
        }
    }
}
