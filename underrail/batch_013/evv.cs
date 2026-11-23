using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A2B RID: 2603
[eiz("RNDEXPBLSPSEZT")]
[Serializable]
public sealed class evv : bdw, ISerializable
{
	// Token: 0x06003DDD RID: 15837 RVA: 0x00174EC8 File Offset: 0x001730C8
	private evv(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("RNDEXPBLSPSEZT:FD", typeof(c2w)) as c2w);
		this.b = A_0.GetString("RNDEXPBLSPSEZT:RC");
	}

	// Token: 0x06003DDE RID: 15838 RVA: 0x00174F04 File Offset: 0x00173104
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("RNDEXPBLSPSEZT:FD", this.a);
		info.AddValue("RNDEXPBLSPSEZT:RC", this.b);
	}

	// Token: 0x06003DDF RID: 15839 RVA: 0x00174F28 File Offset: 0x00173128
	public c2w b()
	{
		return this.a;
	}

	// Token: 0x06003DE0 RID: 15840 RVA: 0x00174F30 File Offset: 0x00173130
	public void a(c2w A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003DE1 RID: 15841 RVA: 0x00174F3C File Offset: 0x0017313C
	public string a()
	{
		return this.b;
	}

	// Token: 0x06003DE2 RID: 15842 RVA: 0x00174F44 File Offset: 0x00173144
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06003DE3 RID: 15843 RVA: 0x00174F50 File Offset: 0x00173150
	public evv()
	{
	}

	// Token: 0x06003DE4 RID: 15844 RVA: 0x00174F58 File Offset: 0x00173158
	public evv(c2w A_0, string A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06003DE5 RID: 15845 RVA: 0x00174F70 File Offset: 0x00173170
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			d60 d = A_0.a();
			if (d != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					this.b
				})) as c5x;
				if (c5x != null && c5x.s.b != null && c5x.s.b.s().Count <= 1)
				{
					c5x.s.b.s().Add(new e68
					{
						Destination = this.a
					});
				}
			}
		}
	}

	// Token: 0x04001BA9 RID: 7081
	private c2w a;

	// Token: 0x04001BAA RID: 7082
	private string b;
}
