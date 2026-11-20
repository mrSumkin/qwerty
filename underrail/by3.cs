using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

// Token: 0x020018F6 RID: 6390
[eiz("DC2")]
[Serializable]
public sealed class by3 : ISerializable
{
	// Token: 0x060087D6 RID: 34774 RVA: 0x003814F8 File Offset: 0x0037F6F8
	private by3(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<cqh>("DC2:D", ref this.a, A_0);
			this.b = A_0.GetInt32("DC2:UM");
			return;
		}
		if (base.GetType() == typeof(by3))
		{
			this.a = (List<cqh>)A_0.GetValue("_Documents", typeof(List<cqh>));
			this.b = A_0.GetInt32("_UnreadMessages");
			return;
		}
		this.a = (List<cqh>)A_0.GetValue("DocumentContainer+_Documents", typeof(List<cqh>));
		this.b = A_0.GetInt32("DocumentContainer+_UnreadMessages");
	}

	// Token: 0x060087D7 RID: 34775 RVA: 0x003815C0 File Offset: 0x0037F7C0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<cqh>("DC2:D", this.a, info);
		info.AddValue("DC2:UM", this.b);
	}

	// Token: 0x060087D8 RID: 34776 RVA: 0x003815E4 File Offset: 0x0037F7E4
	public ReadOnlyCollection<cqh> a()
	{
		return this.a.AsReadOnly();
	}

	// Token: 0x060087D9 RID: 34777 RVA: 0x003815F4 File Offset: 0x0037F7F4
	public int b()
	{
		return this.b;
	}

	// Token: 0x060087DA RID: 34778 RVA: 0x00381600 File Offset: 0x0037F800
	[CompilerGenerated]
	public void a(EventHandler<ao3> A_0)
	{
		EventHandler<ao3> eventHandler = this.c;
		EventHandler<ao3> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ao3> value = (EventHandler<ao3>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ao3>>(ref this.c, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060087DB RID: 34779 RVA: 0x00381638 File Offset: 0x0037F838
	[CompilerGenerated]
	public void b(EventHandler<ao3> A_0)
	{
		EventHandler<ao3> eventHandler = this.c;
		EventHandler<ao3> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ao3> value = (EventHandler<ao3>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ao3>>(ref this.c, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060087DC RID: 34780 RVA: 0x00381670 File Offset: 0x0037F870
	public by3()
	{
	}

	// Token: 0x060087DD RID: 34781 RVA: 0x00381684 File Offset: 0x0037F884
	public bool a(cqh A_0)
	{
		if (A_0 != null && !this.b(A_0))
		{
			cqh cqh = A_0.e();
			this.a.Insert(0, cqh);
			this.c();
			if (this.c != null)
			{
				this.c(this, new ao3(cqh));
			}
			return true;
		}
		return false;
	}

	// Token: 0x060087DE RID: 34782 RVA: 0x003816E0 File Offset: 0x0037F8E0
	public bool b(cqh A_0)
	{
		by3.a a = new by3.a();
		a.a = A_0;
		return a.a != null && Enumerable.Any<cqh>(this.a, new Func<cqh, bool>(a.a));
	}

	// Token: 0x060087DF RID: 34783 RVA: 0x00381720 File Offset: 0x0037F920
	public void c()
	{
		int num = 0;
		if (this.a != null)
		{
			using (List<cqh>.Enumerator enumerator = this.a.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.Read)
					{
						num++;
					}
				}
			}
		}
		this.b = num;
	}

	// Token: 0x04003581 RID: 13697
	private List<cqh> a = new List<cqh>();

	// Token: 0x04003582 RID: 13698
	private int b;

	// Token: 0x04003583 RID: 13699
	[CompilerGenerated]
	[NonSerialized]
	private EventHandler<ao3> c;

	// Token: 0x020018F7 RID: 6391
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x060087E1 RID: 34785 RVA: 0x0038179C File Offset: 0x0037F99C
		internal bool a(cqh A_0)
		{
			return A_0.Code == this.a.Code;
		}

		// Token: 0x04003584 RID: 13700
		public cqh a;
	}
}
