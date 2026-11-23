using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B64 RID: 2916
[eiz("DUITMCLJ")]
[Serializable]
public sealed class agb : cze, ISerializable
{
	// Token: 0x060042B6 RID: 17078 RVA: 0x0019E58C File Offset: 0x0019C78C
	private agb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("DUITMCLJ:L");
		this.b = A_0.GetBoolean("DUITMCLJ:I");
	}

	// Token: 0x060042B7 RID: 17079 RVA: 0x0019E5B8 File Offset: 0x0019C7B8
	public int b()
	{
		return this.a;
	}

	// Token: 0x060042B8 RID: 17080 RVA: 0x0019E5C0 File Offset: 0x0019C7C0
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060042B9 RID: 17081 RVA: 0x0019E5CC File Offset: 0x0019C7CC
	public bool a()
	{
		return this.b;
	}

	// Token: 0x060042BA RID: 17082 RVA: 0x0019E5D4 File Offset: 0x0019C7D4
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060042BB RID: 17083 RVA: 0x0019E5E0 File Offset: 0x0019C7E0
	public agb()
	{
	}

	// Token: 0x060042BC RID: 17084 RVA: 0x0019E5EC File Offset: 0x0019C7EC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		List<int> classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<List<int>>("frag_dun_up_it_coldLevels");
		if (classPropertyValue != null && Enumerable.Count<int>(classPropertyValue) == 4)
		{
			if (this.a > 0 && this.a < 5)
			{
				if (this.a())
				{
					int a_ = 3;
					List<int> list = classPropertyValue;
					int num = this.b() - 1;
					int num2 = list[num];
					list[num] = num2 + 1;
					d05.a(a_, num2);
				}
				else
				{
					int a_2 = 1;
					List<int> list2 = classPropertyValue;
					int num2 = this.b() - 1;
					int num = list2[num2];
					list2[num2] = num - 1;
					d05.b(a_2, num);
				}
				serviceOrThrow.aqu().r()["frag_dun_up_it_coldLevels"] = classPropertyValue;
			}
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				List<b0b> list3 = d.ab4(new string[]
				{
					"frozenPipe_btm"
				});
				foreach (b0b b0b in list3)
				{
					c5x a_3 = (c5x)b0b;
					this.a(serviceOrThrow, a_3);
				}
				list3.Clear();
				list3 = d.ab4(new string[]
				{
					"frozenPipe_up"
				});
				foreach (b0b b0b2 in list3)
				{
					c5x a_4 = (c5x)b0b2;
					this.a(serviceOrThrow, a_4);
				}
			}
		}
	}

	// Token: 0x060042BD RID: 17085 RVA: 0x0019E794 File Offset: 0x0019C994
	private void a(cnk A_0, c5x A_1)
	{
		string text = A_1.Area.y8();
		List<int> classPropertyValue = A_0.aqu().r().GetClassPropertyValue<List<int>>("frag_dun_up_it_coldLevels");
		if (classPropertyValue != null && classPropertyValue.Count >= 3)
		{
			int num = 0;
			if (text.Equals("dun_up_it2") || text.Equals("dun_up_it2_entrance") || text.Equals("dun_up_it2_sideRoom"))
			{
				num = classPropertyValue[0];
			}
			else if (text.Equals("dun_up_it2_up") || text.Equals("dun_up_it2_sideRoomUp"))
			{
				num = classPropertyValue[1];
			}
			else if (text.Equals("dun_up_it3") || text.Equals("dun_up_it3_northSideRoom") || text.Equals("dun_up_it3_westSideRoom"))
			{
				num = classPropertyValue[2];
			}
			else if (text.Equals("dun_up_it3_up") || text.Equals("dun_up_it3_dom") || text.Equals("dun_up_it3_domSideRoom"))
			{
				num = classPropertyValue[3];
			}
			if (num > 3)
			{
				num = 3;
			}
			if (A_1.o.b.b.Y % 2 == 0)
			{
				A_1.o.b.b.Y = num * 2;
				return;
			}
			A_1.o.b.b.Y = num * 2 + 1;
		}
	}

	// Token: 0x04001C29 RID: 7209
	private new int a;

	// Token: 0x04001C2A RID: 7210
	private bool b;
}
