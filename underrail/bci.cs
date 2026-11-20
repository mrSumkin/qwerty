using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Locale;

// Token: 0x020011BE RID: 4542
[eiz("ZSC")]
[Serializable]
public sealed class bci : dth, ISerializable
{
	// Token: 0x0600610E RID: 24846 RVA: 0x002A5930 File Offset: 0x002A3B30
	private bci(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (ZoneControlLevel)A_0.GetValue("ZSC:L", typeof(ZoneControlLevel));
	}

	// Token: 0x0600610F RID: 24847 RVA: 0x002A5958 File Offset: 0x002A3B58
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("ZSC:L", this.a);
	}

	// Token: 0x06006110 RID: 24848 RVA: 0x002A5970 File Offset: 0x002A3B70
	public ZoneControlLevel a()
	{
		return this.a;
	}

	// Token: 0x06006111 RID: 24849 RVA: 0x002A5978 File Offset: 0x002A3B78
	public void a(ZoneControlLevel A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006112 RID: 24850 RVA: 0x002A5984 File Offset: 0x002A3B84
	public bci()
	{
	}

	// Token: 0x06006113 RID: 24851 RVA: 0x002A598C File Offset: 0x002A3B8C
	public bci(ZoneControlLevel A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006114 RID: 24852 RVA: 0x002A599C File Offset: 0x002A3B9C
	public bool jh(object A_0)
	{
		ll ll = A_0 as ll;
		if (ll != null && ll.a() != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				d4n d4n = service.ahu(ll.a());
				if (d4n != null && d4n.b != null && d4n.b.a8() != null && d4n.b.a8().Zone != null)
				{
					return eir.d(d4n.b.a8().Zone) == this.a;
				}
			}
		}
		return false;
	}

	// Token: 0x06006115 RID: 24853 RVA: 0x002A5A30 File Offset: 0x002A3C30
	public string ji()
	{
		return null;
	}

	// Token: 0x04002956 RID: 10582
	private ZoneControlLevel a;
}
