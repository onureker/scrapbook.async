# scrapbook.async

IBTech is a subsdiary of qnb finansbank and it is a IT company, employing 500 people. Nearly half of the company is software developer, and they are mostly distributed into teams related to business domains. On the other hand the "Business Infra Architect" team that I am leading, is not related to any specific business domain.

My Team has two major responsibilities; First, we are developing stand-alone and challenging softwares which can be delivered as product and not directly connected to whole core banking framework. And also developing common business requirements for core banking modules, is our responsilbity too.

I have other duties besides the team's responsibilities

As a part of software development lifecycle in IBTech, I have the role of reviewing and advising all completed or ongoing architectural designs in my company. The purposes of desgin reviews are

Supervising the company compliance of architectural design for each and every project
Awareness of common business infrastructures may be established or used
My other responsiblity in my company is running technical workshops for archtitects and engineers about "design patterns and principles" and "clean code"

So far, we have designed and developed many projects within the company, two of them are cirital and major.


---------------------------------------
ödeme talimatı -> Payment Instructions

First one is maestro.

In our country almost all of the cities has its own electricty, natural gas, providers. They provide online services for invoice and payment order operations. In order to increase customer satisfaction, our company aims to be integrated with these companies. It was decided to write a common integration platform in line with this objective. But company integration methods were very different from each other

The diversity of technology applied in services that compaines provide for operations. Although most of them use web services or Restful services, they also use ISO messages over TCP or offline insfratructure via FTP
Variability of service direction. Most of company host services for operations, but the rest of the them enforces to adapt their certain WSDL
Authentication and authorizarion levels are different from each other. Some of them dont use any authentication, but on the other hand some of them uses WS-Security standarts for sign and encryption
With the aim of handling these requirements we developed project named "Maestro".

The facilities provided by Maestro are
Rapid and simple company integration. The development period, which was 1 month in advance, was reduced to 1 week regardless of the technology applied by company
Extensiblity. For example 3 day development effort was sufficent to implement Ws-Security standarts, and for the driver developer it is as easy as to annotate a class
Tracebility. All protocol messages are logged to observe the problems that can be encountered with the companies
Debugging. The driver developer can debug any driver without application server
Scalability and isolation. An error that may occur in driver does not affect the others. And a driver can be scaled depending on the driver load
Facilities: Resumable Operations, LongRunnnig Operations, MultiTry Operations, Hiearchical & Inheritable Configuration
All aspect concepts are utilized by maestro

Currently 200+ drivers are developed by other teams. (each driver has 50 simple implemntation classe, and 500 LOC)
Infrastutre enforces developers to write clean codes via operation interfaces. For example interns are developing drivers too :)
8 instances of maestro is handling 600.000 transactions per day.
5 years old now.. we developed in 6 months and also enhancments are developed as needed. Dependecny injection container is used, so transparent facilities are provided. Java 1.6 is used, WebSphere, 8 instance, hibernate, yaml, Axis2, Axis1, Wink, Guice Challenges; Easy development, scalability, tracability, maintanablity, flexiblity
---------------------------------------
Performed by or realized

Second one is hermes.

Finansbank calls its own customers due to variour purposes like Collection, Campaing, Information, Security and etc. These calls are realized by bank's own department as well as by outsource companies.
Customer dissatifaction can occur due to the aggresive approach of outsource companies or operational faults of business stakeholders.
In order to increase customer satisfaction and to comply the governance regulations, the project named "Hermes" is designed and developed by my team

The purpose of the hermes project is to regulate customer calls.
All companies should get permission from hermes via web services before calling the customers and give feedback after the call to ask for the next action.
Hermes' call permession and feedback action decisions are given according to the complex rule sets defined by business stakeholders.

One of the challenges of this project is to define these rules dynamically and to include wide range of time frame.
For example one of the 20 rules currently defined in the system is
"If a customer is attempted 5 times in 3 week for campaign and higher prioity purposes, then customer can not be called with in 6 weeks for the purpose of collection or lower prioitrized purposes"
This rule can be revised as 1 year as it covers a wide range of time.


The challenge is Although the decision rules are so complex and the decision context is huge (up to 12 months) the system can respond in very short time.
Otherwise call agent performance may decrease and broke all prediciton algorithm of call engines. Also system must have high availability, because any waiting time of agent is reflected as financial damage to finansbank. However it is not implemented yet, also the system is designed for all types of customer contacts like, e-mail, sms, etc.

Also I suggested, artifical intellgince systems are planned to be applied this decision engine. Because of the demographic informations of customer can vary and has big impact on the decision

Current statistc of the hermes is; the response time is 1.4 ms, 50.000 requests per hour, and %99,99 availabilty

Aras is a cargo company. The compnay was resturing whole applications, and lifecycyles. I consulted them about these subjects. At first we implemented SDLC process via Jira, SVN, Jenkins, Nuget and SynbolSource. And integrate all these tools with each other. At the same time, we utilized Bosphorus Framework to redisgn their business services. It new application infrasture implemented by DDD concept and 3 tier insfratructure.

I can negotiate if needed, but it is Around two months

Roles and responsbilities solution arch, what are expectation, Day to day job

Codes are writeen in java -> development is performed Write application -> Develop application, Develope software (Write code) Outside of the framework -> We dont utilize the framework Actually çok kullanıyorum.. Well, Calls are made -> Performed veya Realized Dissatisfaction TimeFrame to call the customer The first responsiblity is Screen X User Interface Business Stakeholder, Defines the rules

Biolare plate...
