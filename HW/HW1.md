# **Homework 1: เลือกฟังคลิปแล้วสรุปเนื้อหา**

## **Name and ID:**

- **Name:**  นายสัณหธรรศน์ จึงธีรพานิช
- **ID:**    66102010154

## **Summary Content:**

### **Software Design:**
Software design isn't just about code. it's an exercise in **human relationships.** 

Constraints on any process design that you choose is
1. **Social:** We have to build, maintain trust, repair relationship when they've been damage. If I have an API and you're calling the API and I want to change the design of API, then you say The new API sucker because you have to change all your code to call the new API (You're not going to be happy with me). The way to address that is to align ```Authority``` and ```Responsibility```. You have to understand the thinking behind old API and now maybe you have to understand the new API. It's a responsibility of the designer who making design change to make sure that everybody learns what they need to learn in order to adapt to the new design change.
2. **Incentive:** If you're going to design software. You need to reginize that ```everybody's incentives are not the same```. It's okay we don't all have to see things the same way, But we have to agree on next step to take.
3. **Change:** The social structure that you build is going to change over time. Juniors don't stay Juniors forever not if you do it right people, People come, People go, Market change, Technology change.

### **Cost of software**
Why software is expensive. He references **Constantine's Equivalence**, which states that the total cost of software is roughly equal to the cost of making chagrs, which in turn is driven by the cost of **"Big changes."** He explains the **Coupling**-the degree to which different parts of the code depend on each other-is the primary driver of rhese costs. If code is highly coupled, ```a small change can trigger a **"cascading"** effect``` (like a snow avalanche), making development unpredictable and expensive

The Strategy of **"Tidying"**

To manage these costs, Beck suggests ```Tidying```-small, low-risk structural changes (refactorings) performed right before implementing a new behavior. This approach reduces coupling and makes the actual feature implementation **"dead simple"**, there by lowering the overall cost and risk.

## **Additional Vocabulary:**

- **API:** Application Programming Interface
- **Waterfall**
- **Tidying:** Small, low-risk structural changes made to the code (Refactoring) right before adding a new feature. The goal is to make the code easier to understand or **cleaner** so that the next change (the new feature) becomes very simple to implement.
- **Coupling:** The degree to which different parts of a software system depend on each other.
- **Cohesion:** The measure of how strongly related the function or logic within a single module or class are.
- **Constantine's Equivalence:** This implies that the total cost of software is essentially driven by the cost od making changes, and the cost of changes is driven primarily by coupling.

## **Reference Source:**

- [Click here to access source](https://youtu.be/Saaz6D1azlU?si=9fhnndp0M50kZHYh) (YouTube Link)
- **Time:** 23:40 - 38:05
