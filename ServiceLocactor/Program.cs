using ServiceLocactor;

IService svr = ServiceLocator.SetLocation(new LoggingService());
svr.ExecuteService();
