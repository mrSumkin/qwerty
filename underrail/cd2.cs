using System;
using System.Runtime.Serialization;

// Token: 0x02000656 RID: 1622
[eiz("DLE")]
[Serializable]
public abstract class cd2 : ISerializable
{
	// Token: 0x06002926 RID: 10534 RVA: 0x000EAEB0 File Offset: 0x000E90B0
	protected cd2(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("DLE:C");
		this.b = (A_0.GetValue("DLE:CT", typeof(TimeSpan?)) as TimeSpan?);
		this.c = (A_0.GetValue("DLE:DP", typeof(TimeSpan?)) as TimeSpan?);
	}

	// Token: 0x06002927 RID: 10535 RVA: 0x000EAF20 File Offset: 0x000E9120
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("DLE:C", this.a);
		info.AddValue("DLE:CT", this.b);
		info.AddValue("DLE:DP", this.c);
	}

	// Token: 0x06002928 RID: 10536 RVA: 0x000EAF60 File Offset: 0x000E9160
	public string c()
	{
		return this.a;
	}

	// Token: 0x06002929 RID: 10537 RVA: 0x000EAF68 File Offset: 0x000E9168
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600292A RID: 10538
	public abstract TimeSpan ge();

	// Token: 0x0600292B RID: 10539
	public abstract TimeSpan gf();

	// Token: 0x0600292C RID: 10540 RVA: 0x000EAF74 File Offset: 0x000E9174
	public virtual TimeSpan ew()
	{
		return TimeSpan.FromMinutes(1.0);
	}

	// Token: 0x0600292D RID: 10541 RVA: 0x000EAF84 File Offset: 0x000E9184
	public virtual TimeSpan ex()
	{
		return TimeSpan.FromMinutes(1.0);
	}

	// Token: 0x0600292E RID: 10542 RVA: 0x000EAF94 File Offset: 0x000E9194
	public virtual bool ey()
	{
		return true;
	}

	// Token: 0x0600292F RID: 10543 RVA: 0x000EAF98 File Offset: 0x000E9198
	protected cd2()
	{
	}

	// Token: 0x06002930 RID: 10544 RVA: 0x000EAFA0 File Offset: 0x000E91A0
	protected cd2(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002931 RID: 10545 RVA: 0x000EAFB0 File Offset: 0x000E91B0
	public bool a(cyt A_0)
	{
		if (this.b == null)
		{
			this.b = new TimeSpan?(A_0.o());
		}
		io service = bpo.GetService<io>();
		if (this.ey() || service == null || !service.ahg())
		{
			if (this.ez(A_0))
			{
				if (this.c == null)
				{
					this.c = new TimeSpan?(A_0.o() + this.ew() + TimeSpan.FromMilliseconds(new Random(this.GetHashCode()).NextDouble() * this.ex().TotalMilliseconds));
				}
				else if (A_0.o() >= this.c.Value)
				{
					TimeSpan t = A_0.o() - this.b.Value;
					TimeSpan t2 = this.ge() + TimeSpan.FromMilliseconds(new Random(this.GetHashCode()).NextDouble() * this.gf().TotalMilliseconds);
					if (t >= t2)
					{
						this.gg(A_0);
						return true;
					}
				}
			}
			else
			{
				this.c = null;
			}
		}
		return false;
	}

	// Token: 0x06002932 RID: 10546 RVA: 0x000EB0E8 File Offset: 0x000E92E8
	protected virtual bool ez(cyt A_0)
	{
		return true;
	}

	// Token: 0x06002933 RID: 10547
	protected abstract void gg(cyt A_0);

	// Token: 0x04001681 RID: 5761
	private string a;

	// Token: 0x04001682 RID: 5762
	private TimeSpan? b;

	// Token: 0x04001683 RID: 5763
	private TimeSpan? c;
}
