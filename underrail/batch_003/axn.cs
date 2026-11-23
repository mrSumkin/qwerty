using System;
using System.Runtime.ExceptionServices;
using Galaxy.Api;
using Ouroboros.Core.Logging;

// Token: 0x0200029C RID: 668
public class axn : acv
{
	// Token: 0x0600137F RID: 4991 RVA: 0x00051534 File Offset: 0x0004F734
	public bool su()
	{
		return this.a;
	}

	// Token: 0x06001380 RID: 4992 RVA: 0x00051540 File Offset: 0x0004F740
	[HandleProcessCorruptedStateExceptions]
	public bool sv()
	{
		try
		{
			GalaxyInstance.Init(new InitParams("48576370202691252", "84468c814bc64323031d9be7fd7c75c2d32167961295a7c6b0a3d344e15ff704"));
			if (this.e == null)
			{
				this.e = new axn.b(this);
			}
			if (this.f == null)
			{
				this.f = new axn.c(this);
			}
			if (this.g == null)
			{
				this.g = new axn.a(this);
			}
			GalaxyInstance.User().SignInGalaxy();
			this.a = true;
		}
		catch (Exception ex)
		{
			cvq cvq = dr3.e();
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 119))
			{
				cvq.n7(LogSeverity.Error, 119, "[Galaxy Manager] Error occurred while initializing Galaxy. Exception: " + ex.ToString());
			}
		}
		this.d = DateTime.Now;
		return this.a;
	}

	// Token: 0x06001381 RID: 4993 RVA: 0x00051624 File Offset: 0x0004F824
	[HandleProcessCorruptedStateExceptions]
	public void sw()
	{
		if (!this.a)
		{
			if (DateTime.Now > this.d + TimeSpan.FromMinutes(5.0))
			{
				this.sv();
				return;
			}
		}
		else
		{
			try
			{
				GalaxyInstance.ProcessData();
			}
			catch (Exception ex)
			{
				cvq cvq = dr3.e();
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 119))
				{
					cvq.n7(LogSeverity.Error, 119, "[Galaxy Manager] Error occurred while calling GalaxyInstance.ProcessData(). Exception: " + ex.ToString());
				}
			}
		}
	}

	// Token: 0x06001382 RID: 4994 RVA: 0x000516CC File Offset: 0x0004F8CC
	[HandleProcessCorruptedStateExceptions]
	public void sx()
	{
		if (this.a)
		{
			try
			{
				GalaxyInstance.Shutdown(true);
			}
			catch (Exception ex)
			{
				cvq cvq = dr3.e();
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 119))
				{
					cvq.n7(LogSeverity.Error, 119, "[Galaxy Manager] Error occurred while shuting down Galaxy. Exception: " + ex.ToString());
				}
			}
		}
	}

	// Token: 0x06001383 RID: 4995 RVA: 0x00051744 File Offset: 0x0004F944
	[HandleProcessCorruptedStateExceptions]
	public bool sy(bool A_0)
	{
		if (this.a && this.b && this.c)
		{
			try
			{
				GalaxyInstance.Stats().ResetStatsAndAchievements();
				GalaxyInstance.Stats().StoreStatsAndAchievements();
				return true;
			}
			catch (Exception ex)
			{
				cvq cvq = dr3.e();
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 119))
				{
					cvq.n7(LogSeverity.Error, 119, "[Galaxy Manager] Error occurred while reseting Galaxy stats and achievements. Exception: " + ex.ToString());
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x06001384 RID: 4996 RVA: 0x000517E4 File Offset: 0x0004F9E4
	[HandleProcessCorruptedStateExceptions]
	public bool sz(string A_0)
	{
		if (this.a && this.b && this.c)
		{
			try
			{
				GalaxyInstance.Stats().SetAchievement(A_0);
				GalaxyInstance.Stats().StoreStatsAndAchievements();
				return true;
			}
			catch (Exception ex)
			{
				cvq cvq = dr3.e();
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 119))
				{
					cvq.n7(LogSeverity.Error, 119, "[Galaxy Manager] Error occurred while setting Galaxy achievement '" + A_0 + "'. Exception: " + ex.ToString());
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x06001385 RID: 4997 RVA: 0x0005188C File Offset: 0x0004FA8C
	[HandleProcessCorruptedStateExceptions]
	public bool s0(string A_0)
	{
		if (this.a && this.b && this.c)
		{
			try
			{
				GalaxyInstance.Stats().ClearAchievement(A_0);
				GalaxyInstance.Stats().StoreStatsAndAchievements();
				return true;
			}
			catch (Exception ex)
			{
				cvq cvq = dr3.e();
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 119))
				{
					cvq.n7(LogSeverity.Error, 119, "[Galaxy Manager] Error occurred while clearing Galaxy achievement '" + A_0 + "'. Exception: " + ex.ToString());
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x00051934 File Offset: 0x0004FB34
	[HandleProcessCorruptedStateExceptions]
	public bool s1(string A_0)
	{
		if (this.a && this.b && this.c)
		{
			try
			{
				int num = GalaxyInstance.Stats().GetStatInt(A_0);
				num++;
				GalaxyInstance.Stats().SetStatInt(A_0, num);
				GalaxyInstance.Stats().StoreStatsAndAchievements();
				eil service = bpo.GetService<eil>();
				dh2 dh;
				if (service != null && service.aq4() != null && service.aq4().TryGetValue(A_0, out dh) && dh != null && num >= dh.a())
				{
					this.sz(dh.b());
				}
				return true;
			}
			catch (Exception ex)
			{
				cvq cvq = dr3.e();
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 119))
				{
					cvq.n7(LogSeverity.Error, 119, "[Galaxy Manager] Error occurred while incrementing Galaxy stat '" + A_0 + "'. Exception: " + ex.ToString());
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x04000A9D RID: 2717
	private bool a;

	// Token: 0x04000A9E RID: 2718
	private bool b;

	// Token: 0x04000A9F RID: 2719
	private bool c;

	// Token: 0x04000AA0 RID: 2720
	private DateTime d;

	// Token: 0x04000AA1 RID: 2721
	private axn.b e;

	// Token: 0x04000AA2 RID: 2722
	private axn.c f;

	// Token: 0x04000AA3 RID: 2723
	private axn.a g;

	// Token: 0x0200029D RID: 669
	private class b : GlobalAuthListener
	{
		// Token: 0x06001388 RID: 5000 RVA: 0x00051A44 File Offset: 0x0004FC44
		public b(axn A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00051A54 File Offset: 0x0004FC54
		public override void OnAuthFailure(IAuthListener.FailureReason failureReason)
		{
			this.a.b = false;
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00051A64 File Offset: 0x0004FC64
		public override void OnAuthLost()
		{
			this.a.b = false;
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00051A74 File Offset: 0x0004FC74
		public override void OnAuthSuccess()
		{
			this.a.b = true;
			GalaxyInstance.Stats().RequestUserStatsAndAchievements();
		}

		// Token: 0x04000AA4 RID: 2724
		private axn a;
	}

	// Token: 0x0200029E RID: 670
	private class c : GlobalOperationalStateChangeListener
	{
		// Token: 0x0600138C RID: 5004 RVA: 0x00051A8C File Offset: 0x0004FC8C
		public c(axn A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00051A9C File Offset: 0x0004FC9C
		public override void OnOperationalStateChanged(uint operationalState)
		{
		}

		// Token: 0x04000AA5 RID: 2725
		private axn a;
	}

	// Token: 0x0200029F RID: 671
	private class a : GlobalUserStatsAndAchievementsRetrieveListener
	{
		// Token: 0x0600138E RID: 5006 RVA: 0x00051AA0 File Offset: 0x0004FCA0
		public a(axn A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00051AB0 File Offset: 0x0004FCB0
		public override void OnUserStatsAndAchievementsRetrieveFailure(GalaxyID userID, IUserStatsAndAchievementsRetrieveListener.FailureReason failureReason)
		{
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00051AB4 File Offset: 0x0004FCB4
		public override void OnUserStatsAndAchievementsRetrieveSuccess(GalaxyID userID)
		{
			this.a.c = true;
		}

		// Token: 0x04000AA6 RID: 2726
		private axn a;
	}
}
