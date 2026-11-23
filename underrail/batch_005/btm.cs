using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework.Content;
using Ouroboros.Core.Logging;

// Token: 0x02000077 RID: 119
[eiz("A2")]
[Serializable]
public abstract class btm : c7t, a9q, ISerializable
{
	// Token: 0x06000252 RID: 594 RVA: 0x0000BD14 File Offset: 0x00009F14
	protected btm(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (Guid)A_0.GetValue("A2:I", typeof(Guid));
			this.b = A_0.GetString("A2:N");
			this.c = (d3s)A_0.GetValue("A2:EH", typeof(d3s));
			this.d = (btm)A_0.GetValue("A2:P", typeof(btm));
			this.e = A_0.GetBoolean("A2:IA");
			if (ell.b() >= 11)
			{
				this.f = A_0.GetBoolean("A2:C");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(btm))
			{
				this.a = (Guid)A_0.GetValue("_Id", typeof(Guid));
				this.b = A_0.GetString("_Name");
				this.c = (d3s)A_0.GetValue("_ErrorHandling", typeof(d3s));
				this.d = (btm)A_0.GetValue("_Parent", typeof(btm));
				this.e = A_0.GetBoolean("_IsAsync");
				return;
			}
			this.a = (Guid)A_0.GetValue("Activity+_Id", typeof(Guid));
			this.b = A_0.GetString("Activity+_Name");
			this.c = (d3s)A_0.GetValue("Activity+_ErrorHandling", typeof(d3s));
			this.d = (btm)A_0.GetValue("Activity+_Parent", typeof(btm));
			this.e = A_0.GetBoolean("Activity+_IsAsync");
		}
	}

	// Token: 0x06000253 RID: 595 RVA: 0x0000BEF0 File Offset: 0x0000A0F0
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("A2:I", this.a);
		info.AddValue("A2:N", this.b);
		info.AddValue("A2:EH", this.c);
		info.AddValue("A2:P", this.d);
		info.AddValue("A2:IA", this.e);
		info.AddValue("A2:C", this.f);
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x06000254 RID: 596 RVA: 0x0000BF70 File Offset: 0x0000A170
	public Guid Id
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x06000255 RID: 597 RVA: 0x0000BF78 File Offset: 0x0000A178
	public string Name
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000256 RID: 598 RVA: 0x0000BF80 File Offset: 0x0000A180
	// (set) Token: 0x06000257 RID: 599 RVA: 0x0000BF88 File Offset: 0x0000A188
	public d3s ErrorHandling
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000258 RID: 600 RVA: 0x0000BF94 File Offset: 0x0000A194
	// (set) Token: 0x06000259 RID: 601 RVA: 0x0000BF9C File Offset: 0x0000A19C
	public btm Parent
	{
		get
		{
			return this.d;
		}
		set
		{
			this.d = value;
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x0600025A RID: 602 RVA: 0x0000BFA8 File Offset: 0x0000A1A8
	[ContentSerializerIgnore]
	public btm Root
	{
		get
		{
			if (this.d != null)
			{
				return this.d.Root;
			}
			return this;
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x0600025B RID: 603 RVA: 0x0000BFC4 File Offset: 0x0000A1C4
	// (set) Token: 0x0600025C RID: 604 RVA: 0x0000BFCC File Offset: 0x0000A1CC
	public bool IsAsync
	{
		get
		{
			return this.e;
		}
		set
		{
			this.e = value;
		}
	}

	// Token: 0x0600025D RID: 605 RVA: 0x0000BFD8 File Offset: 0x0000A1D8
	protected btm(string A_0 = null)
	{
		this.a = Guid.NewGuid();
		this.b = (A_0 ?? base.GetType().Name);
	}

	// Token: 0x0600025E RID: 606 RVA: 0x0000C010 File Offset: 0x0000A210
	public cdv d(e6d A_0)
	{
		if (this.f)
		{
			return cdv.c;
		}
		cdv result;
		try
		{
			if (this.b4(A_0))
			{
				result = cdv.b;
			}
			else
			{
				result = cdv.a;
			}
		}
		catch (Exception a_)
		{
			if (this.c != d3s.b)
			{
				if (this.c == d3s.c)
				{
					btm btm = this.aeo(a_);
					if (btm != null)
					{
						d4m service = bpo.GetService<d4m>();
						if (service != null)
						{
							service.avp(btm);
						}
						return cdv.c;
					}
				}
				throw;
			}
			result = cdv.b;
		}
		return result;
	}

	// Token: 0x0600025F RID: 607 RVA: 0x0000C0A0 File Offset: 0x0000A2A0
	public cdv f(e6d A_0)
	{
		if (this.f)
		{
			return cdv.c;
		}
		cdv result;
		try
		{
			if (this.aen(A_0))
			{
				result = cdv.b;
			}
			else
			{
				result = cdv.a;
			}
		}
		catch (Exception a_)
		{
			this.a(a_);
			if (this.c != d3s.b)
			{
				if (this.c == d3s.c)
				{
					btm btm = this.aeo(a_);
					if (btm != null)
					{
						d4m service = bpo.GetService<d4m>();
						if (service != null)
						{
							service.avp(btm);
						}
						this.a(btm);
						return cdv.c;
					}
				}
				throw;
			}
			this.a();
			result = cdv.b;
		}
		return result;
	}

	// Token: 0x06000260 RID: 608 RVA: 0x0000C144 File Offset: 0x0000A344
	public void g(e6d A_0)
	{
		try
		{
			this.aep(A_0);
		}
		catch (Exception ex)
		{
			cvq service = bpo.GetService<cvq>();
			if (service != null && service.n8() && service.n9(LogSeverity.Error, 117))
			{
				string a_ = string.Format("[Id_WorkflowManager] - Error occurred while pausing activity '{0}'. Exception: {1}.", this.ToString(), ex.ToString());
				service.n7(LogSeverity.Error, 117, a_);
			}
		}
	}

	// Token: 0x06000261 RID: 609 RVA: 0x0000C1BC File Offset: 0x0000A3BC
	public void e(e6d A_0)
	{
		try
		{
			this.aeq(A_0);
		}
		catch (Exception ex)
		{
			cvq service = bpo.GetService<cvq>();
			if (service != null && service.n8() && service.n9(LogSeverity.Error, 117))
			{
				string a_ = string.Format("[Id_WorkflowManager] - Error occurred while resuming activity '{0}'. Exception: {1}.", this.ToString(), ex.ToString());
				service.n7(LogSeverity.Error, 117, a_);
			}
		}
	}

	// Token: 0x06000262 RID: 610 RVA: 0x0000C234 File Offset: 0x0000A434
	public void n()
	{
		this.au7();
		this.f = true;
	}

	// Token: 0x06000263 RID: 611 RVA: 0x0000C244 File Offset: 0x0000A444
	protected virtual void au7()
	{
	}

	// Token: 0x06000264 RID: 612 RVA: 0x0000C248 File Offset: 0x0000A448
	protected virtual btm aeo(Exception A_0)
	{
		return null;
	}

	// Token: 0x06000265 RID: 613 RVA: 0x0000C24C File Offset: 0x0000A44C
	public sealed override bool Equals(object obj)
	{
		return base.Equals(obj);
	}

	// Token: 0x06000266 RID: 614 RVA: 0x0000C258 File Offset: 0x0000A458
	public sealed override int GetHashCode()
	{
		return base.GetHashCode();
	}

	// Token: 0x06000267 RID: 615 RVA: 0x0000C260 File Offset: 0x0000A460
	public override string ToString()
	{
		return string.Format("{0} - {1}", this.a, this.b);
	}

	// Token: 0x06000268 RID: 616 RVA: 0x0000C280 File Offset: 0x0000A480
	protected virtual bool b4(e6d A_0)
	{
		return false;
	}

	// Token: 0x06000269 RID: 617 RVA: 0x0000C284 File Offset: 0x0000A484
	protected virtual bool aen(e6d A_0)
	{
		return true;
	}

	// Token: 0x0600026A RID: 618 RVA: 0x0000C288 File Offset: 0x0000A488
	protected virtual void aep(e6d A_0)
	{
	}

	// Token: 0x0600026B RID: 619 RVA: 0x0000C28C File Offset: 0x0000A48C
	protected virtual void aeq(e6d A_0)
	{
	}

	// Token: 0x0600026C RID: 620 RVA: 0x0000C290 File Offset: 0x0000A490
	private void a(btm A_0)
	{
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Warning, 117))
		{
			string a_ = string.Format("[Workflow Manager] - Compensating activity '{0}' with activity '{1}'.", this.ToString(), A_0.ToString());
			cvq.n7(LogSeverity.Warning, 117, a_);
		}
	}

	// Token: 0x0600026D RID: 621 RVA: 0x0000C2E4 File Offset: 0x0000A4E4
	private void a()
	{
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Warning, 117))
		{
			string a_ = string.Format("[Workflow Manager] - Skipping activity '{0}'.", this.ToString());
			cvq.n7(LogSeverity.Warning, 117, a_);
		}
	}

	// Token: 0x0600026E RID: 622 RVA: 0x0000C334 File Offset: 0x0000A534
	private void a(Exception A_0)
	{
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 117))
		{
			string a_ = string.Format("[Workflow Manager] - Error occurred while updating activity '{0}'. Exception: {1}.", this.ToString(), A_0.ToString());
			cvq.n7(LogSeverity.Error, 117, a_);
		}
	}

	// Token: 0x040003A7 RID: 935
	private Guid a;

	// Token: 0x040003A8 RID: 936
	private string b;

	// Token: 0x040003A9 RID: 937
	private d3s c;

	// Token: 0x040003AA RID: 938
	private btm d;

	// Token: 0x040003AB RID: 939
	private bool e;

	// Token: 0x040003AC RID: 940
	private bool f;
}
