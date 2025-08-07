# Chemical-Tank-Simulation--Design-Patterns

# Chemical Storage Tank Simulator

This project is a school assignment developed to demonstrate a basic WPF (Windows Presentation Foundation) application using the **MVVM (Model-View-ViewModel)** design pattern. The application simulates a storage tank for different chemical products.

## Project Description

The application consists of a user interface where a user can interact with a simulated storage tank.  
It includes the following core features:

### Features

- **Product Selection**  
  Select from a predefined list of chemical products:
  - Salpeterzuur
  - Aceton
  - Zwavelzuur
  - Ammoniak

- **Storage Tank (Opslagvat)**  
  The main simulation component:
  - `HuidigeInhoud`: Current content level
  - `MaxCapaciteit`: Maximum capacity, which depends on the selected product

- **Functionalities**
  - **Fill (Vul)**: Increases the tank's content by **200 ml/s** (`InloopDebiet`)
  - **Empty (Openen)**: Decreases the tank's content by **100 ml/s** (`UitloopDebiet`)
  - **Clean (Schoonmaken)**: Resets the content to 0 and clears the selected product

## Technologies Used

- **C#**: Primary language for application logic  
- **WPF**: Used to design the graphical user interface  
- **XAML**: Markup language used to define UI elements (`MainWindow.xaml`)  

## How to Run

1. Open the project in **Visual Studio**
2. Make sure all dependencies are installed
3. Press **F5** or click the **Start** button to run the application
4. Interact with the simulation: select a product and manage the tank’s content

---

> This project was created for educational purposes and showcases basic MVVM implementation in a WPF environment.
